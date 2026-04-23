/**
 * Demo live-data layer
 *
 * Keeps demo/sample prices and KPIs looking alive without changing server-side
 * model binding, persisted data, or real production values.
 */
(function () {
  'use strict';

  const liveClockSelector = '[data-demo-live-clock]';
  const explicitPriceSelector = '[data-demo-live-price]';
  const explicitKpiSelector = '[data-demo-live-kpi]';
  const demoPageSelector = '.pc-demo-live-alert';
  const initializedAttr = 'data-demo-live-initialized';
  const liraSymbol = '\u20ba';

  const timeFormatter = new Intl.DateTimeFormat('tr-TR', {
    hour: '2-digit',
    minute: '2-digit',
    second: '2-digit'
  });

  const decimalFormatter = new Intl.NumberFormat('tr-TR', {
    minimumFractionDigits: 2,
    maximumFractionDigits: 2
  });

  const integerFormatter = new Intl.NumberFormat('tr-TR', {
    maximumFractionDigits: 0
  });

  const compactFormatter = new Intl.NumberFormat('tr-TR', {
    maximumFractionDigits: 1
  });

  function onReady(callback) {
    if (document.readyState === 'loading') {
      document.addEventListener('DOMContentLoaded', callback, { once: true });
      return;
    }

    callback();
  }

  function hashSeed(value) {
    const source = String(value || '');
    let hash = 2166136261;

    for (let index = 0; index < source.length; index += 1) {
      hash ^= source.charCodeAt(index);
      hash += (hash << 1) + (hash << 4) + (hash << 7) + (hash << 8) + (hash << 24);
    }

    return (hash >>> 0) / 4294967295;
  }

  function parseLocalizedNumber(value) {
    if (!value) {
      return Number.NaN;
    }

    let normalized = String(value)
      .trim()
      .replace(/\s+/g, '')
      .replace(/[^\d,.\-+]/g, '');

    if (!normalized || !/\d/.test(normalized)) {
      return Number.NaN;
    }

    const hasComma = normalized.includes(',');
    const hasDot = normalized.includes('.');

    if (hasComma) {
      normalized = normalized.replace(/\./g, '').replace(',', '.');
    } else if (hasDot) {
      const dotParts = normalized.split('.');
      const lastPart = dotParts[dotParts.length - 1];

      if (dotParts.length > 2 || lastPart.length === 3) {
        normalized = normalized.replace(/\./g, '');
      }
    }

    return Number.parseFloat(normalized);
  }

  function pulse(element) {
    element.classList.remove('pc-live-updated');
    window.requestAnimationFrame(function () {
      element.classList.add('pc-live-updated');
    });
  }

  function isDemoPage() {
    return Boolean(document.querySelector(demoPageSelector));
  }

  function hasInteractiveChildren(element) {
    return Boolean(element.querySelector('input, select, textarea, button, a'));
  }

  function isLikelyMoneyText(text) {
    if (!/\d/.test(text) || !(text.includes(liraSymbol) || /\bTL\b/i.test(text)) || text.length > 32 || /[\r\n]/.test(text)) {
      return false;
    }

    const currencyPattern = liraSymbol.replace(/[.*+?^${}()|[\]\\]/g, '\\$&');
    const moneyPattern = new RegExp(
      '^\\s*(?:' + currencyPattern + '\\s*)?[+-]?(?:\\d{1,3}(?:[.,]\\d{3})*|\\d+)(?:[.,]\\d+)?\\s*(?:' + currencyPattern + '|TL)?\\s*$',
      'i'
    );

    return moneyPattern.test(text);
  }

  function isLikelyKpiText(text) {
    if (!/\d/.test(text) || text.length > 18 || /[/:]/.test(text)) {
      return false;
    }

    return /%|^\+?[\d.,]+\s*[kKmM]?$/.test(text.trim());
  }

  function inferCurrency(text) {
    return /\bTL\b/i.test(text) && !text.includes(liraSymbol) ? 'TL' : liraSymbol;
  }

  function defaultPriceVolatility(baseValue) {
    if (baseValue >= 1000) {
      return Math.max(baseValue * 0.0025, 4);
    }

    if (baseValue >= 100) {
      return Math.max(baseValue * 0.004, 0.35);
    }

    return Math.max(baseValue * 0.025, 0.04);
  }

  function computeLiveValue(baseValue, volatility, seed, timeScale) {
    const now = Date.now();
    const phase = seed * Math.PI * 2;
    const slowWave = Math.sin(now / timeScale + phase);
    const microWave = Math.sin(now / (timeScale * 0.42) + phase * 1.7) * 0.28;

    return Math.max(0.01, baseValue + (slowWave + microWave) * volatility);
  }

  function trendMarkup(nextValue, previousValue) {
    const delta = previousValue > 0 ? ((nextValue - previousValue) / previousValue) * 100 : 0;
    const directionClass = delta >= 0 ? 'pc-live-trend--up' : 'pc-live-trend--down';
    const sign = delta >= 0 ? '+' : '';
    const text = sign + compactFormatter.format(delta) + '%';

    return '<span class="pc-live-trend ' + directionClass + '" aria-hidden="true">' + text + '</span>';
  }

  function setLivePrice(element, nextValue) {
    const previousValue = Number.parseFloat(element.dataset.demoLiveCurrent || element.dataset.basePrice || nextValue);
    const currency = element.dataset.demoLiveCurrency || liraSymbol;
    const formattedValue = decimalFormatter.format(nextValue) + ' ' + currency;

    element.dataset.demoLiveCurrent = String(nextValue);
    element.innerHTML = '<span class="pc-live-value">' + formattedValue + '</span>' + trendMarkup(nextValue, previousValue);
    pulse(element);
  }

  function collectPriceTargets() {
    const targets = new Set(document.querySelectorAll(explicitPriceSelector));

    if (isDemoPage()) {
      document
        .querySelectorAll('td, .badge, .pc-metric-value, .pc-stat-value, .pc-kpi-card__value, .card-title, .card-text')
        .forEach(function (element) {
          const text = element.textContent.trim();

          if (
            element.hasAttribute(initializedAttr) ||
            element.matches(explicitKpiSelector) ||
            hasInteractiveChildren(element) ||
            !isLikelyMoneyText(text) ||
            !Number.isFinite(parseLocalizedNumber(text))
          ) {
            return;
          }

          element.setAttribute('data-demo-live-price', '');
          targets.add(element);
        });
    }

    return Array.from(targets);
  }

  function initializePrices() {
    const targets = collectPriceTargets();

    targets.forEach(function (element, index) {
      if (element.hasAttribute(initializedAttr)) {
        return;
      }

      const originalText = element.textContent.trim();
      const baseValue = Number.parseFloat(element.dataset.basePrice || '') || parseLocalizedNumber(originalText);

      if (!Number.isFinite(baseValue)) {
        return;
      }

      element.setAttribute(initializedAttr, 'price');
      element.dataset.basePrice = String(baseValue);
      element.dataset.priceVolatility = String(
        Number.parseFloat(element.dataset.priceVolatility || '') || defaultPriceVolatility(baseValue)
      );
      element.dataset.demoLiveSeed = String(hashSeed(originalText + ':' + index + ':' + window.location.pathname));
      element.dataset.demoLiveCurrency = inferCurrency(originalText);
      element.classList.add('pc-live-price');

      setLivePrice(element, computeLiveValue(baseValue, Number.parseFloat(element.dataset.priceVolatility), Number.parseFloat(element.dataset.demoLiveSeed), 8200));
    });

    return targets;
  }

  function inferKpiOptions(element, text) {
    const explicitPrefix = element.dataset.demoKpiPrefix;
    const explicitSuffix = element.dataset.demoKpiSuffix;
    const trimmed = text.trim();
    const compactSuffixMatch = trimmed.match(/[kKmM]$/);

    let prefix = '';
    let suffix = '';

    if (explicitPrefix !== undefined) {
      prefix = explicitPrefix;
    } else if (trimmed.startsWith('+%')) {
      prefix = '+%';
    } else if (trimmed.startsWith('%')) {
      prefix = '%';
    } else if (trimmed.startsWith('+')) {
      prefix = '+';
    }

    if (explicitSuffix !== undefined) {
      suffix = explicitSuffix;
    } else if (trimmed.endsWith('%') && !prefix.includes('%')) {
      suffix = '%';
    } else if (compactSuffixMatch) {
      suffix = compactSuffixMatch[0];
    }

    return {
      prefix: prefix,
      suffix: suffix,
      decimals: Number.parseInt(element.dataset.demoKpiDecimals || '', 10)
    };
  }

  function defaultKpiVolatility(baseValue, options) {
    if (options.prefix.includes('%') || options.suffix.includes('%')) {
      return Math.max(Math.abs(baseValue) * 0.012, 0.4);
    }

    return Math.max(Math.abs(baseValue) * 0.01, 1);
  }

  function formatKpiValue(value, options) {
    const hasDecimals = Number.isFinite(options.decimals) ? options.decimals : Math.abs(value) < 10 ? 1 : 0;
    const formatter = hasDecimals > 0
      ? new Intl.NumberFormat('tr-TR', { maximumFractionDigits: hasDecimals })
      : integerFormatter;
    const numericText = formatter.format(value);

    return options.prefix + numericText + options.suffix;
  }

  function setLiveKpi(element, nextValue, options) {
    element.textContent = formatKpiValue(nextValue, options);
    pulse(element);
  }

  function collectKpiTargets() {
    const targets = new Set(document.querySelectorAll(explicitKpiSelector));

    if (isDemoPage()) {
      document.querySelectorAll('.pc-metric-value, .pc-stat-value, .pc-kpi-card__value, .card h3, .card h4').forEach(function (element) {
        const text = element.textContent.trim();

        if (
          element.hasAttribute(initializedAttr) ||
          element.matches(explicitPriceSelector) ||
          hasInteractiveChildren(element) ||
          isLikelyMoneyText(text) ||
          !isLikelyKpiText(text) ||
          !Number.isFinite(parseLocalizedNumber(text))
        ) {
          return;
        }

        element.setAttribute('data-demo-live-kpi', '');
        targets.add(element);
      });
    }

    return Array.from(targets);
  }

  function initializeKpis() {
    const targets = collectKpiTargets();

    targets.forEach(function (element, index) {
      if (element.hasAttribute(initializedAttr)) {
        return;
      }

      const originalText = element.textContent.trim();
      const baseValue = Number.parseFloat(element.dataset.demoKpiBase || '') || parseLocalizedNumber(originalText);

      if (!Number.isFinite(baseValue)) {
        return;
      }

      const options = inferKpiOptions(element, originalText);
      const volatility = Number.parseFloat(element.dataset.demoKpiVolatility || '') || defaultKpiVolatility(baseValue, options);

      element.setAttribute(initializedAttr, 'kpi');
      element.dataset.demoKpiBase = String(baseValue);
      element.dataset.demoKpiVolatility = String(volatility);
      element.dataset.demoLiveSeed = String(hashSeed(originalText + ':' + index + ':' + window.location.pathname));
      element.dataset.demoKpiPrefix = options.prefix;
      element.dataset.demoKpiSuffix = options.suffix;
      element.classList.add('pc-live-kpi');

      setLiveKpi(element, computeLiveValue(baseValue, volatility, Number.parseFloat(element.dataset.demoLiveSeed), 11200), options);
    });

    return targets;
  }

  function updateClocks() {
    document.querySelectorAll(liveClockSelector).forEach(function (element) {
      element.textContent = timeFormatter.format(new Date());
    });
  }

  function startLiveUpdates() {
    const priceTargets = initializePrices();
    const kpiTargets = initializeKpis();

    updateClocks();
    window.setInterval(updateClocks, 1000);

    if (priceTargets.length > 0) {
      window.setInterval(function () {
        priceTargets.forEach(function (element) {
          const baseValue = Number.parseFloat(element.dataset.basePrice);
          const volatility = Number.parseFloat(element.dataset.priceVolatility);
          const seed = Number.parseFloat(element.dataset.demoLiveSeed);

          if (Number.isFinite(baseValue) && Number.isFinite(volatility) && Number.isFinite(seed)) {
            setLivePrice(element, computeLiveValue(baseValue, volatility, seed, 8200));
          }
        });
      }, 4200);
    }

    if (kpiTargets.length > 0) {
      window.setInterval(function () {
        kpiTargets.forEach(function (element) {
          const options = {
            prefix: element.dataset.demoKpiPrefix || '',
            suffix: element.dataset.demoKpiSuffix || '',
            decimals: Number.parseInt(element.dataset.demoKpiDecimals || '', 10)
          };
          const baseValue = Number.parseFloat(element.dataset.demoKpiBase);
          const volatility = Number.parseFloat(element.dataset.demoKpiVolatility);
          const seed = Number.parseFloat(element.dataset.demoLiveSeed);

          if (Number.isFinite(baseValue) && Number.isFinite(volatility) && Number.isFinite(seed)) {
            setLiveKpi(element, computeLiveValue(baseValue, volatility, seed, 11200), options);
          }
        });
      }, 5200);
    }

    document.documentElement.classList.add('pc-demo-live-ready');
  }

  onReady(startLiveUpdates);
})();
