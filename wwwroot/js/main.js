/**
 * Main
 */

'use strict';

let menu, animate;
document.addEventListener('DOMContentLoaded', function () {
  // class for ios specific styles
  if (navigator.userAgent.match(/iPhone|iPad|iPod/i)) {
    document.body.classList.add('ios');
  }
});

(function () {
  const layoutRoot = document.documentElement;
  const desktopMenuStateKey = 'pazarcep_layout_menu_collapsed_v2';
  const legacyDesktopMenuStateKey = 'pazarcep_layout_menu_collapsed';

  function isSmallScreen() {
    return window.Helpers.isSmallScreen();
  }

  function readDesktopMenuState() {
    try {
      return window.localStorage.getItem(desktopMenuStateKey) === 'true';
    } catch (error) {
      return false;
    }
  }

  function persistDesktopMenuState(collapsed) {
    try {
      window.localStorage.setItem(desktopMenuStateKey, collapsed ? 'true' : 'false');
    } catch (error) {
      // Ignore storage access issues and keep the toggle working.
    }
  }

  function dispatchLayoutResize() {
    window.dispatchEvent(new Event('resize'));
  }

  function clearLegacyDesktopMenuState() {
    try {
      window.localStorage.removeItem(legacyDesktopMenuStateKey);
    } catch (error) {
      // Ignore storage access issues and keep the toggle working.
    }
  }

  function syncMenuToggleButtons() {
    const menuOpen = isSmallScreen()
      ? layoutRoot.classList.contains('layout-menu-expanded')
      : !layoutRoot.classList.contains('layout-menu-collapsed');

    document.querySelectorAll('[data-pc-menu-toggle="layout"], .layout-menu-toggle').forEach(item => {
      const label = menuOpen ? 'Menüyü kapat' : 'Menüyü aç';
      item.setAttribute('aria-expanded', menuOpen ? 'true' : 'false');
      item.setAttribute('aria-label', label);
      item.classList.toggle('is-active', menuOpen);

      const labelTarget = item.querySelector('[data-pc-menu-label]');
      if (labelTarget) {
        labelTarget.textContent = label;
      }
    });
  }

  function applyDesktopMenuState(collapsed, persist = false, shouldResize = false) {
    layoutRoot.classList.toggle('layout-menu-collapsed', collapsed);
    layoutRoot.classList.remove('layout-menu-expanded');

    if (persist) {
      persistDesktopMenuState(collapsed);
    }

    syncMenuToggleButtons();

    if (shouldResize) {
      dispatchLayoutResize();
    }
  }

  function applyMobileMenuState(expanded, shouldResize = false) {
    layoutRoot.classList.toggle('layout-menu-expanded', expanded);
    layoutRoot.classList.remove('layout-menu-collapsed');
    syncMenuToggleButtons();

    if (shouldResize) {
      dispatchLayoutResize();
    }
  }

  function syncMenuStateForViewport() {
    if (isSmallScreen()) {
      layoutRoot.classList.remove('layout-menu-collapsed');
      syncMenuToggleButtons();
      return;
    }

    // Do not apply persisted collapsed state on the public presentation/home pages.
    // Always show the menu expanded by default for homepage to ensure discoverability.
    function isPresentationHome() {
      try {
        const p = window.location && window.location.pathname ? window.location.pathname : '/';
        return p === '/' || p.toLowerCase().startsWith('/anasayfa');
      } catch (e) {
        return false;
      }
    }

    if (isPresentationHome()) {
      applyDesktopMenuState(false, false, false);
      return;
    }

    applyDesktopMenuState(readDesktopMenuState(), false, false);
  }

  function toggleLayoutMenu() {
    if (isSmallScreen()) {
      applyMobileMenuState(!layoutRoot.classList.contains('layout-menu-expanded'), true);
      return;
    }

    applyDesktopMenuState(!layoutRoot.classList.contains('layout-menu-collapsed'), true, true);
  }

  // Initialize menu
  //-----------------

  clearLegacyDesktopMenuState();

  let layoutMenuEl = document.querySelectorAll('#layout-menu');
  layoutMenuEl.forEach(function (element) {
    menu = new Menu(element, {
      orientation: 'vertical',
      closeChildren: false
    });
    // Change parameter to true if you want scroll animation
    window.Helpers.scrollToActive((animate = false));
    window.Helpers.mainMenu = menu;
  });

  // Initialize menu togglers and bind click on each
  let menuToggler = document.querySelectorAll('.layout-menu-toggle, [data-pc-menu-toggle="layout"]');
  menuToggler.forEach(item => {
    item.addEventListener('click', event => {
      event.preventDefault();
      toggleLayoutMenu();
    });
  });

  // Display menu toggle (layout-menu-toggle) on hover with delay
  let delay = function (elem, callback) {
    let timeout = null;
    const hoverToggle = document.querySelector('.layout-menu-toggle');
    elem.onmouseenter = function () {
      // Set timeout to be a timer which will invoke callback after 300ms (not for small screen)
      if (!Helpers.isSmallScreen()) {
        timeout = setTimeout(callback, 300);
      } else {
        timeout = setTimeout(callback, 0);
      }
    };

    elem.onmouseleave = function () {
      // Clear any timers set to timeout
      if (hoverToggle) {
        hoverToggle.classList.remove('d-block');
      }
      clearTimeout(timeout);
    };
  };
  if (document.getElementById('layout-menu')) {
    delay(document.getElementById('layout-menu'), function () {
      // not for small screen
      const hoverToggle = document.querySelector('.layout-menu-toggle');
      if (!Helpers.isSmallScreen() && hoverToggle) {
        hoverToggle.classList.add('d-block');
      }
    });
  }

  // Display in main menu when menu scrolls
  let menuInnerContainer = document.getElementsByClassName('menu-inner'),
    menuInnerShadow = document.getElementsByClassName('menu-inner-shadow')[0];
  if (menuInnerContainer.length > 0 && menuInnerShadow) {
    menuInnerContainer[0].addEventListener('ps-scroll-y', function () {
      if (this.querySelector('.ps__thumb-y').offsetTop) {
        menuInnerShadow.style.display = 'block';
      } else {
        menuInnerShadow.style.display = 'none';
      }
    });
  }

  // Init helpers & misc
  // --------------------

  // Init BS Tooltip
  const tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
  tooltipTriggerList.map(function (tooltipTriggerEl) {
    return new bootstrap.Tooltip(tooltipTriggerEl);
  });

  // Accordion active class
  const accordionActiveFunction = function (e) {
    if (e.type == 'show.bs.collapse' || e.type == 'show.bs.collapse') {
      e.target.closest('.accordion-item').classList.add('active');
    } else {
      e.target.closest('.accordion-item').classList.remove('active');
    }
  };

  const accordionTriggerList = [].slice.call(document.querySelectorAll('.accordion'));
  const accordionList = accordionTriggerList.map(function (accordionTriggerEl) {
    accordionTriggerEl.addEventListener('show.bs.collapse', accordionActiveFunction);
    accordionTriggerEl.addEventListener('hide.bs.collapse', accordionActiveFunction);
  });

  // Auto update layout based on screen size
  window.Helpers.setAutoUpdate(true);

  // Toggle Password Visibility
  window.Helpers.initPasswordToggle();

  // Speech To Text
  window.Helpers.initSpeechToText();

  // Manage menu expanded/collapsed with templateCustomizer & local storage
  //------------------------------------------------------------------

  syncMenuStateForViewport();
  window.addEventListener('resize', syncMenuStateForViewport);
})();
// Utils
function isMacOS() {
  return /Mac|iPod|iPhone|iPad/.test(navigator.userAgent);
}
