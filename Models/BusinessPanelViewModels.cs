namespace PazarCep.Models;

public sealed class RoleSwitcherItemViewModel
{
  public required string Text { get; init; }
  public required string Action { get; init; }
  public required bool IsActive { get; init; }
}

public sealed class PanelMetricViewModel
{
  public required string Title { get; init; }
  public required string Value { get; init; }
  public required string Description { get; init; }
  public required string Icon { get; init; }
}

public sealed class PanelTableColumnViewModel
{
  public required string Header { get; init; }
  public required string Key { get; init; }
}

public sealed class PanelTableRowViewModel
{
  public required Dictionary<string, string> Values { get; init; }
  public string? StatusText { get; init; }
  public string StatusTone { get; init; } = "neutral";
}

public sealed class PanelTableViewModel
{
  public required string Title { get; init; }
  public required string Description { get; init; }
  public required IReadOnlyList<PanelTableColumnViewModel> Columns { get; init; }
  public required IReadOnlyList<PanelTableRowViewModel> Rows { get; init; }
}

public sealed class PanelActionViewModel
{
  public required string Text { get; init; }
  public required string Icon { get; init; }
  public required string TargetAction { get; init; }
}

public sealed class PanelTimelineItemViewModel
{
  public required string Title { get; init; }
  public required string Description { get; init; }
  public required string Time { get; init; }
  public required string Tone { get; init; }
}

public sealed class RoleDashboardViewModel
{
  public required string RoleKey { get; init; }
  public required string Title { get; init; }
  public required string Subtitle { get; init; }
  public required string ActiveAction { get; init; }
  public required IReadOnlyList<RoleSwitcherItemViewModel> RoleSwitcher { get; init; }
  public required IReadOnlyList<PanelMetricViewModel> Metrics { get; init; }
  public required IReadOnlyList<PanelTableViewModel> Tables { get; init; }
  public required IReadOnlyList<PanelActionViewModel> QuickActions { get; init; }
  public required IReadOnlyList<PanelTimelineItemViewModel> Timeline { get; init; }
}

public sealed class OperationPageViewModel
{
  public required string RoleKey { get; init; }
  public required string Title { get; init; }
  public required string Subtitle { get; init; }
  public required string ActiveAction { get; init; }
  public required IReadOnlyList<RoleSwitcherItemViewModel> RoleSwitcher { get; init; }
  public required IReadOnlyList<PanelMetricViewModel> Metrics { get; init; }
  public required PanelTableViewModel MainTable { get; init; }
  public required IReadOnlyList<PanelTimelineItemViewModel> SideItems { get; init; }
}

public sealed class FinanceTransactionViewModel
{
  public required int Id { get; init; }
  public required string UserId { get; init; }
  public required string RoleType { get; init; }
  public required string TransactionType { get; init; }
  public required string Category { get; init; }
  public required decimal Amount { get; init; }
  public required DateTime TransactionDate { get; init; }
  public required string PaymentStatus { get; init; }
  public required string RelatedEntityType { get; init; }
  public required string RelatedEntityId { get; init; }
  public required string Description { get; init; }
  public required DateTime CreatedAt { get; init; }
  public required DateTime UpdatedAt { get; init; }
}

public sealed class FinancePageViewModel
{
  public required string RoleKey { get; init; }
  public required string Title { get; init; }
  public required string Subtitle { get; init; }
  public required string ActiveAction { get; init; }
  public required IReadOnlyList<RoleSwitcherItemViewModel> RoleSwitcher { get; init; }
  public required IReadOnlyList<PanelMetricViewModel> Metrics { get; init; }
  public required IReadOnlyList<FinanceTransactionViewModel> Transactions { get; init; }
  public required IReadOnlyList<string> Categories { get; init; }
}

public sealed class WorkerAssignmentViewModel
{
  public required string RoleKey { get; init; }
  public required string Title { get; init; }
  public required string Subtitle { get; init; }
  public required string ActiveAction { get; init; }
  public required IReadOnlyList<RoleSwitcherItemViewModel> RoleSwitcher { get; init; }
  public required PanelTableViewModel Jobs { get; init; }
  public required IReadOnlyList<WorkerCardViewModel> AvailableWorkers { get; init; }
  public required IReadOnlyList<WorkerCardViewModel> AssignedWorkers { get; init; }
  public required decimal OfferedWage { get; init; }
  public required string WorkType { get; init; }
  public required string JobLocation { get; init; }
}

public sealed class WorkerCardViewModel
{
  public required string Id { get; init; }
  public required string Name { get; init; }
  public required string Region { get; init; }
  public required string Skill { get; init; }
  public required string Status { get; init; }
}

public sealed class OperationsCalendarViewModel
{
  public required string RoleKey { get; init; }
  public required string ThemeClass { get; init; }
  public required string Title { get; init; }
  public required string Subtitle { get; init; }
  public required string ActiveAction { get; init; }
  public required IReadOnlyList<RoleSwitcherItemViewModel> RoleSwitcher { get; init; }
  public required IReadOnlyList<PanelActionViewModel> QuickActions { get; init; }
  public required IReadOnlyList<PanelMetricViewModel> FinanceMetrics { get; init; }
  public required IReadOnlyList<OperationsCalendarDayViewModel> Days { get; init; }
  public required IReadOnlyList<WorkerAvailabilityViewModel> AvailableWorkers { get; init; }
  public required IReadOnlyList<WorkerInvitationViewModel> Invitations { get; init; }
  public required IReadOnlyList<PanelTimelineItemViewModel> Timeline { get; init; }
  public required IReadOnlyList<NotificationItemViewModel> Notifications { get; init; }
  public required IReadOnlyList<string> FinanceCategories { get; init; }
  public required string PrimaryJobType { get; init; }
  public required string PrimaryLocation { get; init; }
  public required decimal DefaultOfferedWage { get; init; }
  public required string WorkModel { get; init; }
}

public sealed class OperationsCalendarDayViewModel
{
  public required DateTime Date { get; init; }
  public required bool IsToday { get; init; }
  public required bool IsSelected { get; init; }
  public required string DayTitle { get; init; }
  public required IReadOnlyList<OperationsCalendarEventViewModel> Events { get; init; }
}

public sealed class OperationsCalendarEventViewModel
{
  public required string Title { get; init; }
  public required string TypeText { get; init; }
  public required string StatusText { get; init; }
  public required string Tone { get; init; }
  public required DateTime StartTime { get; init; }
  public required string Location { get; init; }
  public required IReadOnlyList<WorkerAvatarViewModel> ConfirmedWorkers { get; init; }
}

public sealed class WorkerAvatarViewModel
{
  public required string Name { get; init; }
  public required string Initials { get; init; }
}

public sealed class WorkerAvailabilityViewModel
{
  public required string Id { get; init; }
  public required string Name { get; init; }
  public required string Initials { get; init; }
  public required string Location { get; init; }
  public required IReadOnlyList<string> SkillTags { get; init; }
  public required decimal DailyWageExpectation { get; init; }
  public required string AvailabilityStatus { get; init; }
  public required string RatingText { get; init; }
  public required string LastWorkInfo { get; init; }
}

public sealed class WorkerInvitationViewModel
{
  public required string Id { get; init; }
  public required string WorkerName { get; init; }
  public required string JobOwner { get; init; }
  public required string JobType { get; init; }
  public required string Location { get; init; }
  public required DateTime WorkDate { get; init; }
  public required DateTime StartTime { get; init; }
  public required DateTime EndTime { get; init; }
  public required decimal OfferedWage { get; init; }
  public required string WorkModel { get; init; }
  public required bool FoodIncluded { get; init; }
  public required bool TransportIncluded { get; init; }
  public required string InvitationStatus { get; init; }
  public required string StatusTone { get; init; }
  public required DateTime InvitationSentAt { get; init; }
  public required DateTime ApprovalDeadlineAt { get; init; }
  public DateTime? RespondedAt { get; init; }
  public required string RemainingApprovalText { get; init; }
  public required string Notes { get; init; }
}

public sealed class NotificationItemViewModel
{
  public required string Title { get; init; }
  public required string Description { get; init; }
  public required string Tone { get; init; }
  public required string Icon { get; init; }
}

public static class BusinessPanelFactory
{
  private static readonly IReadOnlyList<RoleSwitcherItemViewModel> Roles =
  [
    new() { Text = "Çiftçi", Action = "Ciftci", IsActive = false },
    new() { Text = "Alıcı", Action = "Alici", IsActive = false },
    new() { Text = "Yevmiyeci", Action = "Yevmiyeci", IsActive = false },
    new() { Text = "Lojistik", Action = "Lojistik", IsActive = false },
    new() { Text = "Danışman", Action = "Danisman", IsActive = false }
  ];

  public static IReadOnlyList<RoleSwitcherItemViewModel> RoleSwitcher(string activeAction)
  {
    return Roles.Select(role => new RoleSwitcherItemViewModel
    {
      Text = role.Text,
      Action = role.Action,
      IsActive = role.Action == activeAction
    }).ToList();
  }

  public static IReadOnlyList<RoleSwitcherItemViewModel> OperationsRoleSwitcher(string activeAction)
  {
    var roles = new[]
    {
      new RoleSwitcherItemViewModel { Text = "Çiftçi", Action = "CiftciOperasyon", IsActive = activeAction == "CiftciOperasyon" },
      new RoleSwitcherItemViewModel { Text = "Alıcı", Action = "AliciOperasyon", IsActive = activeAction == "AliciOperasyon" },
      new RoleSwitcherItemViewModel { Text = "Yevmiyeci", Action = "YevmiyeciOperasyon", IsActive = activeAction == "YevmiyeciOperasyon" },
      new RoleSwitcherItemViewModel { Text = "Lojistik", Action = "LojistikOperasyon", IsActive = activeAction == "LojistikOperasyon" },
      new RoleSwitcherItemViewModel { Text = "Danışman", Action = "DanismanOperasyon", IsActive = activeAction == "DanismanOperasyon" }
    };

    return roles;
  }

  public static RoleDashboardViewModel CreateDashboard(string roleKey)
  {
    return roleKey switch
    {
      "Farmer" => CreateFarmerDashboard(),
      "Buyer" => CreateBuyerDashboard(),
      "Worker" => CreateWorkerDashboard(),
      "Logistics" => CreateLogisticsDashboard(),
      "Consultant" => CreateConsultantDashboard(),
      _ => CreateFarmerDashboard()
    };
  }

  public static OperationPageViewModel CreateOperation(string roleKey, string pageKey)
  {
    var activeAction = GetAction(roleKey, pageKey);
    return new()
    {
      RoleKey = roleKey,
      Title = GetOperationTitle(roleKey, pageKey),
      Subtitle = GetOperationSubtitle(roleKey, pageKey),
      ActiveAction = activeAction,
      RoleSwitcher = RoleSwitcher(GetDashboardAction(roleKey)),
      Metrics = GetOperationMetrics(roleKey, pageKey),
      MainTable = GetOperationTable(roleKey, pageKey),
      SideItems = GetOperationSideItems(roleKey, pageKey)
    };
  }

  public static FinancePageViewModel CreateFinance(string roleKey)
  {
    var transactions = CreateFinanceTransactions(roleKey);
    var income = transactions.Where(item => item.TransactionType == "Income").Sum(item => item.Amount);
    var expense = transactions.Where(item => item.TransactionType == "Expense").Sum(item => item.Amount);

    return new()
    {
      RoleKey = roleKey,
      Title = $"{GetRoleText(roleKey)} Gelir / Gider",
      Subtitle = "Gelir, gider, ödeme durumu ve ilgili operasyon bağlantılarını tek tabloda izleyin.",
      ActiveAction = GetAction(roleKey, "Finance"),
      RoleSwitcher = RoleSwitcher(GetDashboardAction(roleKey)),
      Metrics =
      [
        Metric("Aylık Gelir", FormatMoney(income), "Bu ay kaydedilen tahsilatlar", "bx-trending-up"),
        Metric("Aylık Gider", FormatMoney(expense), "Bu ay oluşan maliyetler", "bx-trending-down"),
        Metric("Net Bakiye", FormatMoney(income - expense), "Gelir eksi gider", "bx-wallet"),
        Metric("Bekleyen Ödeme", FormatMoney(transactions.Where(item => item.PaymentStatus != "Ödendi").Sum(item => item.Amount)), "Açık ödeme kayıtları", "bx-time-five")
      ],
      Transactions = transactions,
      Categories = transactions.Select(item => item.Category).Distinct().OrderBy(item => item).ToList()
    };
  }

  public static WorkerAssignmentViewModel CreateAssignment(string roleKey)
  {
    var isBuyer = roleKey == "Buyer";
    return new()
    {
      RoleKey = roleKey,
      Title = isBuyer ? "Ürün İndirme İşleri" : "İşçi / Yevmiye Takibi",
      Subtitle = isBuyer
        ? "Teslim gelen ürünler için indirme ekibini planlayın, onayları ve toplam işçilik maliyetini görün."
        : "Tarla işleri için yevmiyeci daveti oluşturun, ekip atayın ve maliyeti önceden hesaplayın.",
      ActiveAction = isBuyer ? "AliciIndirme" : "CiftciYevmiye",
      RoleSwitcher = RoleSwitcher(isBuyer ? "Alici" : "Ciftci"),
      Jobs = GetOperationTable(roleKey, isBuyer ? "Unloading" : "WorkerAssignment"),
      AvailableWorkers =
      [
        new() { Id = "WRK-101", Name = "Mehmet Kaya", Region = "Akhisar", Skill = "Hasat / yükleme", Status = "Uygun" },
        new() { Id = "WRK-102", Name = "Ayşe Demir", Region = "Salihli", Skill = "Ayıklama / paketleme", Status = "Uygun" },
        new() { Id = "WRK-103", Name = "Hasan Çelik", Region = "Turgutlu", Skill = "Sulama / budama", Status = "Davet bekliyor" },
        new() { Id = "WRK-104", Name = "Fatma Aydın", Region = "Akhisar", Skill = "İndirme / düzenleme", Status = "Uygun" }
      ],
      AssignedWorkers =
      [
        new() { Id = "WRK-201", Name = "Zeynep Arslan", Region = "Merkez", Skill = isBuyer ? "Ürün indirme" : "Hasat", Status = "Kabul etti" },
        new() { Id = "WRK-202", Name = "Ali Şahin", Region = "Merkez", Skill = isBuyer ? "Kasa dizimi" : "Yükleme", Status = "Davet edildi" }
      ],
      OfferedWage = isBuyer ? 950 : 1100,
      WorkType = isBuyer ? "Ürün indirme ve tezgah düzenleme" : "Hasat ve yükleme",
      JobLocation = isBuyer ? "Kadıköy hal giriş kapısı" : "Akhisar / Zeytinlik tarla"
    };
  }

  public static OperationsCalendarViewModel CreateOperations(string roleKey)
  {
    var context = GetOperationsContext(roleKey);
    var invitations = CreateWorkerInvitations(roleKey);
    var availableWorkers = CreateAvailableWorkers(roleKey);
    var financeTransactions = CreateFinanceTransactions(roleKey);
    var income = financeTransactions.Where(item => item.TransactionType == "Income").Sum(item => item.Amount);
    var expense = financeTransactions.Where(item => item.TransactionType == "Expense").Sum(item => item.Amount);
    var pendingPayments = financeTransactions.Where(item => item.PaymentStatus != "Ödendi").Sum(item => item.Amount);
    var workerWageTotal = invitations.Where(item => item.InvitationStatus is "Accepted" or "Pending").Sum(item => item.OfferedWage);

    return new()
    {
      RoleKey = roleKey,
      ThemeClass = $"role-theme-{GetThemeKey(roleKey)}",
      Title = context.Title,
      Subtitle = context.Subtitle,
      ActiveAction = context.ActiveAction,
      RoleSwitcher = OperationsRoleSwitcher(context.ActiveAction),
      QuickActions = context.Actions,
      FinanceMetrics =
      [
        Metric("Bugünkü Gelir", FormatMoney(income / 4), "Gün içi tahsilat ve hizmet geliri", "bx-trending-up"),
        Metric("Bugünkü Gider", FormatMoney(expense / 4), "Gün içi operasyon maliyeti", "bx-trending-down"),
        Metric("Aylık Gelir", FormatMoney(income), "Bu ay kayıtlı gelir", "bx-wallet"),
        Metric("Aylık Gider", FormatMoney(expense), "Bu ay kayıtlı gider", "bx-receipt"),
        Metric("Net Bakiye", FormatMoney(income - expense), "Gelir eksi gider", "bx-line-chart"),
        Metric("Bekleyen Ödeme", FormatMoney(pendingPayments), "Ödeme takibi gereken kayıtlar", "bx-time-five"),
        Metric("İşçilik Toplamı", FormatMoney(workerWageTotal), "Davet edilen ve kabul eden işçiler", "bx-group"),
        Metric(context.CostMetricTitle, context.CostMetricValue, context.CostMetricDescription, context.CostMetricIcon)
      ],
      Days = CreateOperationsDays(roleKey, invitations),
      AvailableWorkers = availableWorkers,
      Invitations = invitations,
      Timeline = CreateOperationsTimeline(roleKey),
      Notifications = CreateNotifications(roleKey, invitations),
      FinanceCategories = CreateFinanceCategories(roleKey),
      PrimaryJobType = context.PrimaryJobType,
      PrimaryLocation = context.PrimaryLocation,
      DefaultOfferedWage = context.DefaultOfferedWage,
      WorkModel = context.WorkModel
    };
  }

  private sealed record OperationsContext(
    string Title,
    string Subtitle,
    string ActiveAction,
    IReadOnlyList<PanelActionViewModel> Actions,
    string PrimaryJobType,
    string PrimaryLocation,
    decimal DefaultOfferedWage,
    string WorkModel,
    string CostMetricTitle,
    string CostMetricValue,
    string CostMetricDescription,
    string CostMetricIcon);

  private static OperationsContext GetOperationsContext(string roleKey)
  {
    return roleKey switch
    {
      "Buyer" => new(
        "Alıcı Operasyon Paneli",
        "Ürün indirme, yevmiyeci çağırma, stok hareketi ve ödeme takibini aynı takvimde yönetin.",
        "AliciOperasyon",
        QuickActions(("İndirme İşi Aç", "bx-user-plus", "AliciIndirme"), ("Alım Kaydı", "bx-cart", "AliciAlimlar"), ("Gelir / Gider", "bx-wallet", "AliciFinans")),
        "Ürün indirme ve kasa düzenleme",
        "Kadıköy hal kabul alanı",
        950,
        "Saatlik",
        "Fire / Paketleme",
        "₺8.900",
        "Bugün planlanan paketleme ve fire maliyeti",
        "bx-package"),
      "Worker" => new(
        "Yevmiyeci Operasyon Paneli",
        "İş davetleri, onay süresi, uygunluk takvimi, kazanç ve ödeme durumunu tek yerden takip edin.",
        "YevmiyeciOperasyon",
        QuickActions(("İş Davetleri", "bx-envelope", "YevmiyeciDavetler"), ("Takvimim", "bx-calendar", "YevmiyeciTakvim"), ("Kazançlarım", "bx-wallet", "YevmiyeciKazanc")),
        "Hasat ve ürün indirme",
        "Akhisar / Kadıköy hattı",
        1100,
        "Yevmiye",
        "Ulaşım Gideri",
        "₺620",
        "Kabul edilen işler için tahmini yol maliyeti",
        "bx-bus"),
      "Logistics" => new(
        "Lojistik Operasyon Paneli",
        "Nakliye işleri, araç planlaması, rota takvimi ve gelir/gider yönetimini rolünüze göre izleyin.",
        "LojistikOperasyon",
        QuickActions(("Nakliye İşi", "bx-trip", "LojistikNakliye"), ("Araçlarım", "bx-car", "LojistikAraclar"), ("Gelir / Gider", "bx-wallet", "LojistikFinans")),
        "Yükleme ve teslimat desteği",
        "Akhisar yükleme noktası",
        1200,
        "Yevmiye",
        "Yakıt / Rota",
        "₺14.200",
        "Bugünkü rota yakıt ve yol maliyeti",
        "bx-gas-pump"),
      "Consultant" => new(
        "Danışman Operasyon Paneli",
        "Randevular, saha ziyaretleri, üretici notları ve danışmanlık gelirlerini birlikte yönetin.",
        "DanismanOperasyon",
        QuickActions(("Randevu Planla", "bx-calendar-plus", "DanismanRandevular"), ("Saha Raporu", "bx-clipboard", "DanismanSaha"), ("Gelir / Gider", "bx-wallet", "DanismanFinans")),
        "Saha ziyareti ve numune hazırlığı",
        "Serik üretici sahası",
        1000,
        "Yevmiye",
        "Saha Ziyareti",
        "₺3.400",
        "Bugünkü ulaşım ve numune maliyeti",
        "bx-briefcase"),
      _ => new(
        "Çiftçi Operasyon Paneli",
        "Tarlalar, işçiler, saha işleri, ödeme hatırlatmaları ve gelir/gider takibini aynı ekranda yönetin.",
        "CiftciOperasyon",
        QuickActions(("İşçi Çağır", "bx-user-plus", "CiftciYevmiye"), ("Tarla İşleri", "bx-task", "CiftciTarlaIsleri"), ("Gelir / Gider", "bx-wallet", "CiftciFinans")),
        "Hasat ve yükleme",
        "Akhisar / Dere Tarla",
        1100,
        "Yevmiye",
        "Tarla Maliyeti",
        "₺11.700",
        "Bugünkü sulama, yakıt ve işçilik maliyeti",
        "bx-leaf")
    };
  }

  private static IReadOnlyList<OperationsCalendarDayViewModel> CreateOperationsDays(string roleKey, IReadOnlyList<WorkerInvitationViewModel> invitations)
  {
    var today = DateTime.Today;
    return Enumerable.Range(0, 7).Select(offset =>
    {
      var date = today.AddDays(offset);
      var eventsForDay = CreateOperationsEvents(roleKey, date, invitations);
      return new OperationsCalendarDayViewModel
      {
        Date = date,
        IsToday = offset == 0,
        IsSelected = offset == 0,
        DayTitle = date.ToString("yyyy.MM.dd"),
        Events = eventsForDay
      };
    }).ToList();
  }

  private static IReadOnlyList<OperationsCalendarEventViewModel> CreateOperationsEvents(string roleKey, DateTime date, IReadOnlyList<WorkerInvitationViewModel> invitations)
  {
    var acceptedWorkers = invitations
      .Where(item => item.InvitationStatus == "Accepted" && item.WorkDate.Date == date.Date)
      .Select(item => CreateAvatar(item.WorkerName))
      .ToList();

    var baseEvent = roleKey switch
    {
      "Buyer" => ("Sabah ürün kabulü", "Ürün indirme", "Onay Bekliyor", "warning", "Kadıköy hal"),
      "Worker" => ("Kabul edilen iş", "Yevmiye işi", "Onaylandı", "success", "Akhisar"),
      "Logistics" => ("Soğuk zincir taşıma", "Nakliye işi", "Devam Ediyor", "info", "Akhisar - Kadıköy"),
      "Consultant" => ("Saha ziyareti", "Ziraat danışmanlığı", "Planlandı", "success", "Serik"),
      _ => ("Dere Tarla hasat işi", "Tarla işi", "Planlandı", "success", "Akhisar")
    };

    var events = new List<OperationsCalendarEventViewModel>
    {
      new()
      {
        Title = baseEvent.Item1,
        TypeText = baseEvent.Item2,
        StatusText = baseEvent.Item3,
        Tone = baseEvent.Item4,
        StartTime = date.AddHours(7),
        Location = baseEvent.Item5,
        ConfirmedWorkers = acceptedWorkers
      }
    };

    if (date.DayOfWeek is DayOfWeek.Wednesday or DayOfWeek.Friday)
    {
      events.Add(new()
      {
        Title = roleKey == "Logistics" ? "Yakıt ödeme hatırlatması" : "Ödeme kontrolü",
        TypeText = "Finans",
        StatusText = "Bekliyor",
        Tone = "warning",
        StartTime = date.AddHours(15),
        Location = "Finans paneli",
        ConfirmedWorkers = []
      });
    }

    return events;
  }

  private static IReadOnlyList<WorkerAvailabilityViewModel> CreateAvailableWorkers(string roleKey)
  {
    var skillPrefix = roleKey switch
    {
      "Buyer" => "İndirme",
      "Logistics" => "Yükleme",
      "Consultant" => "Numune",
      _ => "Hasat"
    };

    return
    [
      Worker("WRK-101", "Mehmet Kaya", "Akhisar", [skillPrefix, "Yükleme"], 1100, "Uygun", "4,8", "Son iş: 2026.05.08"),
      Worker("WRK-102", "Ayşe Demir", "Salihli", ["Ayıklama", "Paketleme"], 1050, "Uygun", "4,7", "Son iş: 2026.05.07"),
      Worker("WRK-103", "Hasan Çelik", "Turgutlu", ["Sulama", "Budama"], 980, "Davet bekliyor", "4,5", "Son iş: 2026.05.06"),
      Worker("WRK-104", "Fatma Aydın", "Merkez", ["Kasa dizimi", "Temizlik"], 950, "Uygun", "4,9", "Son iş: 2026.05.09")
    ];
  }

  private static IReadOnlyList<WorkerInvitationViewModel> CreateWorkerInvitations(string roleKey)
  {
    var now = DateTime.Today.AddHours(10);
    var owner = GetRoleText(roleKey);
    return
    [
      Invitation("INV-2401", "Zeynep Arslan", owner, roleKey == "Buyer" ? "Ürün indirme" : "Hasat", "Akhisar", 0, 7, 12, 1100, "Yevmiye", true, false, "Accepted", "success", now.AddMinutes(-18), now.AddMinutes(-4), "Kabul edildi ve takvimde işçi rozeti gösteriliyor."),
      Invitation("INV-2402", "Ali Şahin", owner, roleKey == "Logistics" ? "Yükleme desteği" : "Yükleme", "Kadıköy", 0, 8, 13, 1000, "Saatlik", false, true, "Pending", "warning", now.AddMinutes(-12), null, "İşçi 30 dakika içinde yanıt vermeli."),
      Invitation("INV-2403", "Elif Koç", owner, "Paketleme", "Bursa", 1, 9, 15, 950, "Kabala", true, true, "Expired", "danger", now.AddMinutes(-55), null, "İşçi 30 dakika içinde onay vermedi. Lütfen başka bir işçi çağırın."),
      Invitation("INV-2404", "Hasan Çelik", owner, "Temizlik", "Salihli", 2, 6, 11, 980, "Yevmiye", false, false, "Rejected", "neutral", now.AddMinutes(-25), now.AddMinutes(-10), "İşçi teklifi reddetti; alternatif işçi çağırılabilir.")
    ];
  }

  private static IReadOnlyList<PanelTimelineItemViewModel> CreateOperationsTimeline(string roleKey)
  {
    return
    [
      new() { Title = "Sabah planı açıldı", Description = $"{GetRoleText(roleKey)} için takvim, işçi daveti ve ödeme kontrolü birlikte listelendi.", Time = "2026.05.11 08:30", Tone = "info" },
      new() { Title = "İşçi onayı alındı", Description = "Kabul eden işçiler takvim hücresinde mini rozet olarak gösteriliyor.", Time = "2026.05.11 09:42", Tone = "success" },
      new() { Title = "Davet süresi doldu", Description = "İşçi 30 dakika içinde onay vermedi. Lütfen başka bir işçi çağırın.", Time = "2026.05.11 10:05", Tone = "warning" }
    ];
  }

  private static IReadOnlyList<NotificationItemViewModel> CreateNotifications(string roleKey, IReadOnlyList<WorkerInvitationViewModel> invitations)
  {
    var expired = invitations.First(item => item.InvitationStatus == "Expired");
    return
    [
      new() { Title = "Bekleyen işçi onayı", Description = "Bir davet 30 dakikalık onay süresi içinde yanıt bekliyor.", Tone = "warning", Icon = "bx-time-five" },
      new() { Title = "Süresi dolan davet", Description = expired.Notes, Tone = "danger", Icon = "bx-error-circle" },
      new() { Title = "Ödeme hatırlatması", Description = $"{GetRoleText(roleKey)} finans kayıtlarında açık ödeme bulunuyor.", Tone = "info", Icon = "bx-wallet" },
      new() { Title = "Yaklaşan plan", Description = "Bugünkü takvimde randevu, iş veya teslimat kaydı var.", Tone = "success", Icon = "bx-calendar-check" }
    ];
  }

  private static IReadOnlyList<string> CreateFinanceCategories(string roleKey)
  {
    return roleKey switch
    {
      "Buyer" => ["Ürün alımı", "Ürün satışı", "İşçi ücreti", "Nakliye", "Paketleme", "Pazar yeri ücreti", "Fire / zayiat", "Diğer"],
      "Worker" => ["İş kazancı", "Avans ödeme", "Yol gideri", "Yemek gideri", "Diğer"],
      "Logistics" => ["Nakliye geliri", "Yakıt", "Bakım", "Sürücü ödemesi", "Yol / geçiş ücreti", "Diğer"],
      "Consultant" => ["Danışmanlık ücreti", "Saha ziyareti ücreti", "Eğitim ücreti", "Ulaşım", "Malzeme", "Ofis gideri", "Diğer"],
      _ => ["Ürün satışı", "İşçi ücreti", "Tohum", "Gübre", "Yakıt", "Sulama", "İlaç", "Ekipman", "Diğer"]
    };
  }

  private static WorkerAvailabilityViewModel Worker(string id, string name, string location, IReadOnlyList<string> skills, decimal wage, string status, string rating, string lastWork) => new()
  {
    Id = id,
    Name = name,
    Initials = GetInitials(name),
    Location = location,
    SkillTags = skills,
    DailyWageExpectation = wage,
    AvailabilityStatus = status,
    RatingText = rating,
    LastWorkInfo = lastWork
  };

  private static WorkerInvitationViewModel Invitation(string id, string workerName, string owner, string jobType, string location, int dayOffset, int startHour, int endHour, decimal wage, string workModel, bool food, bool transport, string status, string tone, DateTime sentAt, DateTime? respondedAt, string notes)
  {
    var workDate = DateTime.Today.AddDays(dayOffset);
    var deadline = sentAt.AddMinutes(30);
    var remaining = status switch
    {
      "Pending" => $"{Math.Max(0, (int)(deadline - DateTime.Today.AddHours(10)).TotalMinutes)} dk kaldı",
      "Accepted" => "Kabul edildi",
      "Expired" => "Süre doldu",
      "Rejected" => "Reddedildi",
      _ => "Takipte"
    };

    return new()
    {
      Id = id,
      WorkerName = workerName,
      JobOwner = owner,
      JobType = jobType,
      Location = location,
      WorkDate = workDate,
      StartTime = workDate.AddHours(startHour),
      EndTime = workDate.AddHours(endHour),
      OfferedWage = wage,
      WorkModel = workModel,
      FoodIncluded = food,
      TransportIncluded = transport,
      InvitationStatus = status,
      StatusTone = tone,
      InvitationSentAt = sentAt,
      ApprovalDeadlineAt = deadline,
      RespondedAt = respondedAt,
      RemainingApprovalText = remaining,
      Notes = notes
    };
  }

  private static WorkerAvatarViewModel CreateAvatar(string name) => new()
  {
    Name = name,
    Initials = GetInitials(name)
  };

  private static string GetInitials(string name)
  {
    var parts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return string.Concat(parts.Take(2).Select(part => part[0])).ToUpperInvariant();
  }

  private static RoleDashboardViewModel CreateFarmerDashboard()
  {
    return new()
    {
      RoleKey = "Farmer",
      Title = "Çiftçi Paneli",
      Subtitle = "Tarlalarınızı, işçi planınızı, hasat beklentinizi ve gelir-gider dengenizi tek çalışma alanında yönetin.",
      ActiveAction = "Ciftci",
      RoleSwitcher = RoleSwitcher("Ciftci"),
      Metrics =
      [
        Metric("Toplam Tarla", "6", "3 sahipli, 3 kiralık arazi", "bx-map-alt"),
        Metric("Aktif Ürün", "9", "Domates, biber, üzüm ve zeytin", "bx-leaf"),
        Metric("Bugünkü İşçi", "14", "2 farklı tarla işinde çalışıyor", "bx-group"),
        Metric("Haftalık İşçilik", "₺42.800", "Planlanan ve gerçekleşen toplam", "bx-wallet"),
        Metric("Beklenen Hasat", "18,4 ton", "Önümüzdeki 30 gün", "bx-package"),
        Metric("Toplam Gelir", "₺286.000", "Bu sezon ürün satışları", "bx-trending-up"),
        Metric("Toplam Gider", "₺164.500", "İşçilik, gübre, yakıt ve sulama", "bx-trending-down"),
        Metric("Net Bakiye", "₺121.500", "Tahmini sezon karlılığı", "bx-line-chart"),
        Metric("Bekleyen Görev", "7", "Sulama, ilaçlama, hasat hazırlığı", "bx-task"),
        Metric("Yaklaşan Hasat", "3", "Bu hafta başlayacak ürünler", "bx-calendar-star")
      ],
      Tables = [GetOperationTable("Farmer", "Fields"), GetOperationTable("Farmer", "FieldWork")],
      QuickActions = QuickActions(("Operasyon Takvimi", "bx-calendar-week", "CiftciOperasyon"), ("Tarla Ekle", "bx-plus", "CiftciTarlalar"), ("İşçi Çağır", "bx-user-plus", "CiftciYevmiye"), ("Gelir / Gider", "bx-wallet", "CiftciFinans")),
      Timeline = GetOperationSideItems("Farmer", "Fields")
    };
  }

  private static RoleDashboardViewModel CreateBuyerDashboard()
  {
    return new()
    {
      RoleKey = "Buyer",
      Title = "Alıcı Paneli",
      Subtitle = "Alımlarınızı, stok değerini, ürün indirme işlerini ve satış-gider dengenizi tek panelden takip edin.",
      ActiveAction = "Alici",
      RoleSwitcher = RoleSwitcher("Alici"),
      Metrics =
      [
        Metric("Aktif Alım Siparişi", "18", "Üretici ve kooperatiflerden açık alım", "bx-cart"),
        Metric("İndirilecek Ürün", "7", "Bugün depoya gelecek teslimatlar", "bx-package"),
        Metric("Bugünkü İşçi İhtiyacı", "11", "İndirme ve kasa düzenleme", "bx-group"),
        Metric("Toplam Alım Maliyeti", "₺382.000", "Bu ay satın alınan ürün", "bx-purchase-tag"),
        Metric("Toplam Satış", "₺514.000", "Market ve toptan satış toplamı", "bx-trending-up"),
        Metric("Toplam Gider", "₺438.500", "Alım, işçilik, nakliye ve fire", "bx-trending-down"),
        Metric("Net Bakiye", "₺75.500", "Brüt operasyon dengesi", "bx-wallet"),
        Metric("Stok Değeri", "₺226.000", "Satış fiyatı ile tahmini değer", "bx-store")
      ],
      Tables = [GetOperationTable("Buyer", "Purchases"), GetOperationTable("Buyer", "Stock")],
      QuickActions = QuickActions(("Operasyon Takvimi", "bx-calendar-week", "AliciOperasyon"), ("Alım Kaydı", "bx-plus", "AliciAlimlar"), ("İndirme Ekibi", "bx-user-plus", "AliciIndirme"), ("Stok", "bx-box", "AliciStok")),
      Timeline = GetOperationSideItems("Buyer", "Purchases")
    };
  }

  private static RoleDashboardViewModel CreateWorkerDashboard()
  {
    return new()
    {
      RoleKey = "Worker",
      Title = "Yevmiyeci Paneli",
      Subtitle = "İş davetlerini, uygun olduğunuz günleri, tamamlanan işleri ve kazanç durumunuzu takip edin.",
      ActiveAction = "Yevmiyeci",
      RoleSwitcher = RoleSwitcher("Yevmiyeci"),
      Metrics =
      [
        Metric("Bugünkü İş", "2", "Hasat ve ürün indirme", "bx-briefcase"),
        Metric("Bekleyen Davet", "4", "Yanıt bekleyen iş teklifleri", "bx-envelope"),
        Metric("Tamamlanan İş", "21", "Bu ay kapatılan işler", "bx-check-circle"),
        Metric("Haftalık Kazanç", "₺8.700", "Onaylanan yevmiyeler", "bx-wallet"),
        Metric("Ödenmemiş Kazanç", "₺2.400", "Tahsilat bekleyen işler", "bx-time-five"),
        Metric("Ödenen Kazanç", "₺16.800", "Bu ay ödenen tutar", "bx-credit-card")
      ],
      Tables = [GetOperationTable("Worker", "Invitations"), GetOperationTable("Worker", "Availability")],
      QuickActions = QuickActions(("Operasyon Takvimi", "bx-calendar-week", "YevmiyeciOperasyon"), ("İş Davetleri", "bx-envelope", "YevmiyeciDavetler"), ("Takvimim", "bx-calendar", "YevmiyeciTakvim"), ("Kazançlarım", "bx-wallet", "YevmiyeciKazanc")),
      Timeline = GetOperationSideItems("Worker", "Invitations")
    };
  }

  private static RoleDashboardViewModel CreateLogisticsDashboard()
  {
    return new()
    {
      RoleKey = "Logistics",
      Title = "Lojistik Paneli",
      Subtitle = "Araçlarınızı, nakliye işlerinizi, rota maliyetlerinizi ve lojistik gelir-gider dengenizi yönetin.",
      ActiveAction = "Lojistik",
      RoleSwitcher = RoleSwitcher("Lojistik"),
      Metrics =
      [
        Metric("Aktif Nakliye", "9", "Bugün rotada olan işler", "bx-trip"),
        Metric("Tamamlanan Teslimat", "34", "Bu ay kapatılan işler", "bx-check-circle"),
        Metric("Uygun Araç", "5", "Bugün atanabilir araçlar", "bx-car"),
        Metric("Yakıt Gideri", "₺48.200", "Bu ay kayıtlı yakıt maliyeti", "bx-gas-pump"),
        Metric("Nakliye Geliri", "₺132.000", "Faturalanan taşıma geliri", "bx-trending-up"),
        Metric("Net Bakiye", "₺54.600", "Gelir eksi lojistik gider", "bx-wallet")
      ],
      Tables = [GetOperationTable("Logistics", "Vehicles"), GetOperationTable("Logistics", "TransportJobs")],
      QuickActions = QuickActions(("Operasyon Takvimi", "bx-calendar-week", "LojistikOperasyon"), ("Araçlarım", "bx-car", "LojistikAraclar"), ("Nakliye İşleri", "bx-trip", "LojistikNakliye"), ("Gelir / Gider", "bx-wallet", "LojistikFinans")),
      Timeline = GetOperationSideItems("Logistics", "TransportJobs")
    };
  }

  private static RoleDashboardViewModel CreateConsultantDashboard()
  {
    return new()
    {
      RoleKey = "Consultant",
      Title = "Danışman Paneli",
      Subtitle = "Randevuları, saha ziyaretlerini, üretici notlarını ve danışmanlık gelir-giderini tek yerden yönetin.",
      ActiveAction = "Danisman",
      RoleSwitcher = RoleSwitcher("Danisman"),
      Metrics =
      [
        Metric("Bugünkü Randevu", "5", "Online ve saha görüşmeleri", "bx-calendar-check"),
        Metric("Yaklaşan Saha Ziyareti", "8", "Önümüzdeki 10 gün", "bx-map-pin"),
        Metric("Aktif Müşteri", "26", "Takip edilen üretici ve işletmeler", "bx-user-check"),
        Metric("Aylık Gelir", "₺74.000", "Danışmanlık ve ziyaret ücretleri", "bx-trending-up"),
        Metric("Aylık Gider", "₺18.500", "Ulaşım ve malzeme giderleri", "bx-trending-down"),
        Metric("Net Bakiye", "₺55.500", "Aylık danışmanlık dengesi", "bx-wallet")
      ],
      Tables = [GetOperationTable("Consultant", "Appointments"), GetOperationTable("Consultant", "Reports")],
      QuickActions = QuickActions(("Operasyon Takvimi", "bx-calendar-week", "DanismanOperasyon"), ("Randevular", "bx-calendar", "DanismanRandevular"), ("Saha Ziyaretleri", "bx-clipboard", "DanismanSaha"), ("Gelir / Gider", "bx-wallet", "DanismanFinans")),
      Timeline = GetOperationSideItems("Consultant", "Appointments")
    };
  }

  private static IReadOnlyList<FinanceTransactionViewModel> CreateFinanceTransactions(string roleKey)
  {
    var roleText = GetRoleText(roleKey);
    return
    [
      Transaction(1, roleText, "Income", roleKey == "Logistics" ? "Nakliye ücreti" : roleKey == "Consultant" ? "Danışmanlık ücreti" : roleKey == "Worker" ? "Yevmiye" : "Ürün satışı", 42000, -8, "Ödendi", "Sipariş", "OP-1001", "Tamamlanan operasyon geliri"),
      Transaction(2, roleText, "Expense", roleKey == "Farmer" ? "İşçi ücreti" : roleKey == "Buyer" ? "Ürün alımı" : roleKey == "Logistics" ? "Yakıt" : roleKey == "Consultant" ? "Ulaşım" : "Yemek / yol", 12800, -6, "Kısmi Ödendi", "İş", "JOB-2304", "Operasyon bağlantılı gider"),
      Transaction(3, roleText, "Income", roleKey == "Buyer" ? "Market satışı" : roleKey == "Worker" ? "Kabala iş" : "Hizmet geliri", 27500, -3, "Ödendi", "Cari", "ACC-204", "Cari hesaba işlenen tahsilat"),
      Transaction(4, roleText, "Expense", roleKey == "Farmer" ? "Gübre" : roleKey == "Buyer" ? "Nakliye" : roleKey == "Logistics" ? "Bakım" : roleKey == "Consultant" ? "Malzeme" : "Ekipman", 6900, -1, "Ödenmedi", "Gider", "EXP-332", "Fatura bekleyen gider kaydı")
    ];
  }

  private static FinanceTransactionViewModel Transaction(int id, string roleType, string transactionType, string category, decimal amount, int dayOffset, string paymentStatus, string relatedType, string relatedId, string description)
  {
    var date = DateTime.Today.AddDays(dayOffset);
    return new()
    {
      Id = id,
      UserId = "USR-DEMO",
      RoleType = roleType,
      TransactionType = transactionType,
      Category = category,
      Amount = amount,
      TransactionDate = date,
      PaymentStatus = paymentStatus,
      RelatedEntityType = relatedType,
      RelatedEntityId = relatedId,
      Description = description,
      CreatedAt = date.AddHours(8),
      UpdatedAt = date.AddHours(17)
    };
  }

  private static PanelMetricViewModel Metric(string title, string value, string description, string icon) => new()
  {
    Title = title,
    Value = value,
    Description = description,
    Icon = icon
  };

  private static IReadOnlyList<PanelActionViewModel> QuickActions(params (string Text, string Icon, string TargetAction)[] actions)
  {
    return actions.Select(action => new PanelActionViewModel { Text = action.Text, Icon = action.Icon, TargetAction = action.TargetAction }).ToList();
  }

  private static PanelTableViewModel GetOperationTable(string roleKey, string pageKey)
  {
    return pageKey switch
    {
      "Fields" => Table("Tarlalarım", "Konum, ürün, sulama ve hasat durumuna göre tarla portföyü.", ["Tarla", "Konum", "Alan", "Ürün", "Ekim", "Hasat", "Sulama", "Mülkiyet"], [
        Row(["Zeytinlik Kuzey", "Akhisar / Manisa", "42 dönüm", "Zeytin", "2026.03.15", "2026.10.18", "Damla sulama", "Sahipli"], "Aktif", "success"),
        Row(["Dere Tarla", "Salihli / Manisa", "18 dönüm", "Domates", "2026.04.02", "2026.07.22", "Kanal sulama", "Kiralık"], "Takipte", "warning"),
        Row(["Bağ Alanı", "Alaşehir / Manisa", "25 dönüm", "Üzüm", "2026.02.12", "2026.09.05", "Planlandı", "Sahipli"], "Hasat Yakın", "info")
      ]),
      "FieldWork" => Table("Tarla İşleri", "Kim, ne zaman, hangi modelle çalıştı ve ödeme durumu.", ["Tarla", "Tarih", "İşçi", "İş Türü", "Model", "Kişi", "Ücret", "Toplam"], [
        Row(["Dere Tarla", "2026.05.02", "Mehmet Kaya", "Sulama", "Yevmiye", "4", "₺1.100", "₺4.400"], "Ödenmedi", "warning"),
        Row(["Zeytinlik Kuzey", "2026.05.01", "Zeynep Arslan", "Budama", "Saatlik", "3", "₺180/saat", "₺3.240"], "Kısmi", "info"),
        Row(["Bağ Alanı", "2026.04.29", "Ekip-12", "Temizlik", "Kabala", "6", "₺9.000", "₺9.000"], "Ödendi", "success")
      ]),
      "WorkerAssignment" => Table("Tarla İş Talepleri", "Tarih, ücret, yemek/yol ve davet durumları.", ["İş", "Tarla", "Tarih", "Saat", "İşçi", "Ücret", "Yemek / Yol", "Durum"], [
        Row(["Hasat başlangıcı", "Dere Tarla", "2026.05.04", "06:30", "8", "₺1.100", "Yemek var / yol yok", "Davet edildi"], "Davet Edildi", "info"),
        Row(["Yükleme", "Zeytinlik Kuzey", "2026.05.06", "14:00", "5", "₺950", "Yemek yok / yol var", "Kabul edildi"], "Kabul Edildi", "success")
      ]),
      "Purchases" => Table("Alım Yönetimi", "Ürün, üretici, miktar, teslimat ve ödeme takibi.", ["Ürün", "Üretici", "Miktar", "Birim", "Birim Fiyat", "Toplam", "Alım Tarihi", "Teslimat"], [
        Row(["Domates", "Demir Organik", "3.200", "kg", "₺28", "₺89.600", "2026.05.02", "Yolda"], "Ödeme Bekliyor", "warning"),
        Row(["Biber", "Yeşilova Çiftliği", "1.750", "kg", "₺34", "₺59.500", "2026.05.01", "Teslim alındı"], "Ödendi", "success"),
        Row(["Elma", "Orta Anadolu Koop.", "2.100", "kg", "₺22", "₺46.200", "2026.04.30", "Planlandı"], "Planlandı", "info")
      ]),
      "Unloading" => Table("Ürün İndirme İşleri", "Depoya gelen ürünler için yevmiyeci ihtiyacı.", ["İş", "Ürün / Sipariş", "Konum", "Tarih", "Saat", "İşçi", "Ücret", "Toplam"], [
        Row(["Sabah indirme", "SC-50124", "Kadıköy hal", "2026.05.03", "07:00", "6", "₺950", "₺5.700"], "Onay Bekliyor", "warning"),
        Row(["Depo düzenleme", "SC-50132", "Bursa depo", "2026.05.04", "10:30", "4", "₺900", "₺3.600"], "Kabul Edildi", "success")
      ]),
      "Stock" => Table("Stok Yönetimi", "Stoktaki miktar, alış-satış fiyatı ve tahmini kar.", ["Ürün", "Stok", "Alış", "Satış", "Tahmini Kar", "Fire", "Hareket"], [
        Row(["Domates", "2.850 kg", "₺28", "₺39", "₺31.350", "80 kg", "Bugün satışta"], "Aktif", "success"),
        Row(["Biber", "1.120 kg", "₺34", "₺46", "₺13.440", "25 kg", "Depoda"], "Aktif", "success"),
        Row(["Elma", "900 kg", "₺22", "₺31", "₺8.100", "15 kg", "Yolda"], "Yolda", "info")
      ]),
      "Invitations" => Table("İş Davetleri", "Çiftçi ve alıcılardan gelen iş teklifleri.", ["İş Sahibi", "İş Türü", "Konum", "Tarih / Saat", "Ücret", "Model", "Yemek / Yol"], [
        Row(["Bereket Tarım", "Hasat", "Akhisar", "2026.05.03 06:30", "₺1.100", "Yevmiye", "Yemek var"], "Kabul Et", "warning"),
        Row(["Kaya Market", "Ürün indirme", "Kadıköy", "2026.05.04 07:00", "₺950", "Saatlik", "Yol var"], "Bekliyor", "info")
      ]),
      "Availability" => Table("Takvimim", "Uygun ve uygun olmayan çalışma günleri.", ["Tarih", "Durum", "Plan", "Konum", "Not"], [
        Row(["2026.05.03", "Uygun", "Hasat işi", "Akhisar", "Sabah uygun"], "Uygun", "success"),
        Row(["2026.05.04", "Dolu", "Ürün indirme", "Kadıköy", "Onaylandı"], "Dolu", "warning")
      ]),
      "Earnings" => Table("Kazançlarım", "İş bazında ödenen ve bekleyen kazançlar.", ["İşveren", "Tarih", "İş Türü", "Tutar", "Durum"], [
        Row(["Bereket Tarım", "2026.04.29", "Hasat", "₺1.100", "Ödendi"], "Ödendi", "success"),
        Row(["Kaya Market", "2026.05.01", "İndirme", "₺950", "Ödenmedi"], "Ödenmedi", "warning")
      ]),
      "Vehicles" => Table("Araçlarım", "Araç, kapasite, sürücü ve durum takibi.", ["Araç", "Plaka", "Tip", "Kapasite", "Sürücü", "Durum", "Not"], [
        Row(["Frigo Kamyon", "34 PC 120", "Soğuk zincir", "8 ton", "Murat Eren", "Uygun", "Bakım yeni yapıldı"], "Uygun", "success"),
        Row(["Kamyonet", "35 PC 245", "Açık kasa", "3 ton", "Selim Kara", "Rotada", "İzmir hattı"], "Rotada", "info")
      ]),
      "TransportJobs" => Table("Nakliye İşleri", "Alış, teslimat, araç, maliyet ve durum takibi.", ["Ürün / Sipariş", "Alış", "Teslim", "Alış Zamanı", "Teslim Zamanı", "Araç", "Ücret", "Yakıt"], [
        Row(["SC-50124", "Akhisar", "Kadıköy", "2026.05.03 06:00", "2026.05.03 10:00", "34 PC 120", "₺12.500", "₺3.200"], "Devam Ediyor", "info"),
        Row(["SC-50132", "Bursa", "Ankara", "2026.05.04 08:30", "2026.05.04 14:00", "35 PC 245", "₺9.400", "₺2.100"], "Planlandı", "warning")
      ]),
      "Appointments" => Table("Randevularım", "Danışmanlık görüşmeleri ve saha ziyaretleri.", ["Müşteri", "Tür", "Tarih / Saat", "Konum", "Şekil", "Ücret", "Ödeme"], [
        Row(["Akdeniz Üretici Birliği", "Saha ziyareti", "2026.05.03 10:00", "Serik", "Yerinde", "₺4.500", "Bekliyor"], "Onaylandı", "success"),
        Row(["Ege Seracılık", "Hastalık analizi", "2026.05.04 15:00", "Online", "Online", "₺2.000", "Ödendi"], "Planlandı", "info")
      ]),
      "Reports" => Table("Saha Ziyaret Raporları", "Gözlem, öneri, ilaç/gübre aksiyonu ve sonraki ziyaret.", ["Müşteri", "Tarla", "Ziyaret", "Gözlem", "Öneri", "Aksiyon", "Sonraki"], [
        Row(["Demir Organik", "Dere Tarla", "2026.04.28", "Yaprak lekesi", "Nem kontrolü", "Bakırlı ilaç", "2026.05.12"], "Takip", "warning"),
        Row(["Yeşilova", "Seralık", "2026.04.30", "Besin eksikliği", "Gübreleme", "Potasyum desteği", "2026.05.14"], "Tamamlandı", "success")
      ]),
      _ => Table("Kayıtlar", "Operasyon kayıtları.", ["Başlık", "Durum"], [Row(["Demo kayıt", "Aktif"], "Aktif", "success")])
    };
  }

  private static IReadOnlyList<PanelMetricViewModel> GetOperationMetrics(string roleKey, string pageKey)
  {
    return pageKey switch
    {
      "Fields" => [Metric("Toplam Tarla", "6", "Aktif arazi kaydı", "bx-map-alt"), Metric("Aktif Ürün", "9", "Üretimdeki ürün", "bx-leaf"), Metric("Yaklaşan Hasat", "3", "30 gün içinde", "bx-calendar-star")],
      "FieldWork" or "WorkerAssignment" or "Unloading" => [Metric("Açık İş", "5", "Planlanan iş", "bx-task"), Metric("Atanan İşçi", "14", "Davet ve kabul toplamı", "bx-group"), Metric("Tahmini Maliyet", "₺18.900", "Ücret ön izleme", "bx-wallet")],
      "Stock" => [Metric("Stok Değeri", "₺226.000", "Satış fiyatı ile", "bx-store"), Metric("Fire", "120 kg", "Son 7 gün", "bx-error"), Metric("Tahmini Kar", "₺52.890", "Mevcut stoktan", "bx-line-chart")],
      _ => [Metric("Aktif Kayıt", "12", "Bu ekrandaki kayıtlar", "bx-list-check"), Metric("Onay Bekleyen", "3", "İşlem bekleyenler", "bx-time-five"), Metric("Tamamlanan", "8", "Kapanan kayıtlar", "bx-check-circle")]
    };
  }

  private static IReadOnlyList<PanelTimelineItemViewModel> GetOperationSideItems(string roleKey, string pageKey)
  {
    return
    [
      new() { Title = "Bugünkü öncelik", Description = $"{GetRoleText(roleKey)} operasyonlarında ilk kontrol edilmesi gereken kayıtlar listelendi.", Time = "2026.05.02 09:00", Tone = "info" },
      new() { Title = "Ödeme kontrolü", Description = "Açık ödeme ve bekleyen tahsilat kayıtları finans paneline bağlandı.", Time = "2026.05.02 11:30", Tone = "warning" },
      new() { Title = "Plan güncellendi", Description = "Takvim, iş ataması ve operasyon listesi aynı demo veri setiyle gösteriliyor.", Time = "2026.05.02 14:15", Tone = "success" }
    ];
  }

  private static PanelTableViewModel Table(string title, string description, IReadOnlyList<string> headers, IReadOnlyList<PanelTableRowViewModel> rows)
  {
    var columns = headers.Select((header, index) => new PanelTableColumnViewModel { Header = header, Key = $"c{index}" }).ToList();
    return new()
    {
      Title = title,
      Description = description,
      Columns = columns,
      Rows = rows
    };
  }

  private static PanelTableRowViewModel Row(IReadOnlyList<string> values, string statusText, string statusTone)
  {
    return new()
    {
      Values = values.Select((value, index) => new { Key = $"c{index}", Value = value }).ToDictionary(item => item.Key, item => item.Value),
      StatusText = statusText,
      StatusTone = statusTone
    };
  }

  private static string GetOperationTitle(string roleKey, string pageKey) => pageKey switch
  {
    "Fields" => "Tarlalarım",
    "FieldWork" => "Tarla İşleri",
    "WorkerAssignment" => "İşçi / Yevmiye Takibi",
    "Purchases" => "Alımlar",
    "Stock" => "Stok",
    "Unloading" => "Ürün İndirme İşleri",
    "Invitations" => "İş Davetleri",
    "Availability" => "Takvimim",
    "Earnings" => "Kazançlarım",
    "Vehicles" => "Araçlarım",
    "TransportJobs" => "Nakliye İşleri",
    "Appointments" => "Randevular",
    "Reports" => "Saha Ziyaretleri",
    _ => $"{GetRoleText(roleKey)} Operasyonları"
  };

  private static string GetOperationSubtitle(string roleKey, string pageKey) => pageKey switch
  {
    "Fields" => "Tarla konumu, ürün, ekim tarihi, hasat beklentisi, sulama ve mülkiyet durumunu yönetin.",
    "FieldWork" => "Tarla bazlı işçilik kayıtlarını, çalışma modelini, kişi sayısını ve ödeme durumunu izleyin.",
    "WorkerAssignment" => "Yevmiyeci daveti oluşturun, işçi atayın ve toplam maliyeti hesaplayın.",
    "Purchases" => "Ürün alımlarını üretici, miktar, fiyat, teslimat ve ödeme durumuyla takip edin.",
    "Stock" => "Stok miktarı, alış-satış fiyatı, fire ve hareket geçmişi için operasyon görünümü.",
    "Unloading" => "Teslim gelen ürünler için işçi ihtiyacı, ücret ve onay durumlarını yönetin.",
    "Invitations" => "Gelen iş davetlerini değerlendirin, ücret ve çalışma koşullarını karşılaştırın.",
    "Availability" => "Uygun günlerinizi, yaklaşan ve tamamlanan işlerinizi görün.",
    "Earnings" => "Kazançlarınızı işveren, tarih, iş türü ve ödeme durumuna göre takip edin.",
    "Vehicles" => "Araç kapasitesi, plaka, sürücü ve operasyon durumunu yönetin.",
    "TransportJobs" => "Alış ve teslim noktaları, araç, yakıt, ücret ve durum takibini yapın.",
    "Appointments" => "Danışmanlık randevularını ücret, ödeme ve görüşme tipiyle takip edin.",
    "Reports" => "Saha gözlemleri, öneriler ve sonraki ziyaret planlarını kayıt altında tutun.",
    _ => "Rol bazlı operasyon kayıtlarını izleyin."
  };

  private static string GetAction(string roleKey, string pageKey) => (roleKey, pageKey) switch
  {
    ("Farmer", "Operations") => "CiftciOperasyon",
    ("Farmer", "Fields") => "CiftciTarlalar",
    ("Farmer", "FieldWork") => "CiftciTarlaIsleri",
    ("Farmer", "WorkerAssignment") => "CiftciYevmiye",
    ("Farmer", "Finance") => "CiftciFinans",
    ("Buyer", "Operations") => "AliciOperasyon",
    ("Buyer", "Purchases") => "AliciAlimlar",
    ("Buyer", "Stock") => "AliciStok",
    ("Buyer", "Unloading") => "AliciIndirme",
    ("Buyer", "Finance") => "AliciFinans",
    ("Worker", "Operations") => "YevmiyeciOperasyon",
    ("Worker", "Invitations") => "YevmiyeciDavetler",
    ("Worker", "Availability") => "YevmiyeciTakvim",
    ("Worker", "Earnings") => "YevmiyeciKazanc",
    ("Logistics", "Operations") => "LojistikOperasyon",
    ("Logistics", "Vehicles") => "LojistikAraclar",
    ("Logistics", "TransportJobs") => "LojistikNakliye",
    ("Logistics", "Finance") => "LojistikFinans",
    ("Consultant", "Operations") => "DanismanOperasyon",
    ("Consultant", "Appointments") => "DanismanRandevular",
    ("Consultant", "Reports") => "DanismanSaha",
    ("Consultant", "Finance") => "DanismanFinans",
    _ => GetDashboardAction(roleKey)
  };

  private static string GetDashboardAction(string roleKey) => roleKey switch
  {
    "Buyer" => "Alici",
    "Worker" => "Yevmiyeci",
    "Logistics" => "Lojistik",
    "Consultant" => "Danisman",
    _ => "Ciftci"
  };

  private static string GetRoleText(string roleKey) => roleKey switch
  {
    "Buyer" => "Alıcı",
    "Worker" => "Yevmiyeci",
    "Logistics" => "Lojistik",
    "Consultant" => "Danışman",
    _ => "Çiftçi"
  };

  private static string GetThemeKey(string roleKey) => roleKey switch
  {
    "Buyer" => "buyer",
    "Worker" => "worker",
    "Logistics" => "logistics",
    "Consultant" => "consultant",
    _ => "farmer"
  };

  private static string FormatMoney(decimal amount) => $"₺{amount:N0}";
}
