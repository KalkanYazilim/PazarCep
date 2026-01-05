UXpilot INSTRUCTIONS (STRICT — DO NOT ADD/REMOVE PAGES)
You are UXpilot. You will produce exactly 128 distinct screens/pages for the PazarCep web platform (mobile-first responsive). Do not add, remove, rename or combine pages beyond this list; follow the specification template below for each page. Primary UI language = Turkish. Also produce an English translation column for every visible UI text string. Deliverables for each page: wireframe (desktop/tablet/mobile), high-fidelity mockup (desktop/tablet/mobile), clickable prototype connections, component specs, accessibility notes, API contract examples, sample test data, analytics events list, and exported assets.

Global project fundamentals (apply to all pages)
Project name: PazarCep

Platform: Web app (mobile-first responsive), supports desktop/tablet/mobile breakpoints.

Breakpoints: Mobile 360–480px, Tablet 768–1024px, Desktop 1280–1440px.

Design tokens: color, spacing, typography, corner radius, shadow scale — produce a tokens file.

Color palette (must use these): Primary Green #28a745, Accent Orange #ff9800, Neutral Whites & Grays.

Typography: use system stack with scales: H1 32px, H2 24px, H3 20px, Body 16px, Small 12px. Provide Turkish diacritic-friendly fonts.

Corner radius: 12px default, 8px for inputs, 20px for large cards.

Elevation: 3-step shadow system.

Accessibility: WCAG AA minimum. Keyboard navigation, focus outlines, ARIA labels for interactive components, sufficient color contrast (provide contrast ratio checks).

Component library: Buttons (primary/secondary/tertiary/icon), Inputs, Selects, Multi-step forms, Modal templates, Toasts, Cards, List items, Avatars, Chips, Filters, Table, Pagination, Map component, Timeline, File uploader with image preview, Rating stars, Bidding component, Calendar picker, Date/time range, Map with route polyline.

Microcopy tone: Clear, supportive, neutral professional. All UI strings given in Turkish (primary) and English (secondary).

Naming conventions: Each screen file should be named: module__screenname__breakpoint e.g. marketplace__product-detail__desktop.

Deliverable formats: Figma (or exportable equivalents), PNG/JPG for previews, component tokens JSON, and a click-through prototype link. Also provide a single-page PDF spec per module summarizing interactions.

Page Specification Template (MUST BE FOLLOWED FOR EVERY PAGE)
For each of the 128 pages produce a specification using this exact template:

Page Title (English / Turkish)

Unique slug (recommended URL)

Page purpose (one short sentence)

Primary roles that can access (list)

Wireframe(s) to produce (desktop / tablet / mobile)

Components on page (detailed list — each component’s props)

Data fields / API contract:

GET/POST endpoints example (path, method)

Request body example

Response example (schema)

Required states:

Default loaded state

Empty state (design + microcopy)

Loading skeleton(s)

Error state(s) and error messages

Success state(s)

Interactions & micro-interactions:

Hover/tap/focus behaviors

Animations and durations

Modals and confirmations (content & buttons)

Validations & microcopy examples (exact Turkish strings + English translations)

Accessibility notes (ARIA attributes, keyboard order)

Responsive specifics (how layout changes across breakpoints; exact elements hidden or collapsed)

Sample test data (3 realistic examples)

Analytics events to capture (eventName, payload)

Security / permission rules (who sees what, role restrictions)

Edge cases (2–3 edge cases and how UI should behave)

Files to export (icons, svgs, images) and asset sizes

QA checklist (10 items)

Prototype connections (from which pages to which pages; specific CTA targets)

You must repeat this full template for every single listed page.

Exact list of 128 pages (do exactly these — grouped by module)
(Count total = 128)

A. Marketing / Public / Legal (13)
Landing / Home — "/"

About — "/about"

Pricing & PazarPara Packages — "/pricing"

How It Works (visual step-by-step) — "/how-it-works"

Testimonials & Success Stories — "/testimonials"

Blog List — "/blog"

Blog Article — "/blog/:slug"

Contact — "/contact"

Help Center / Knowledge Base (list) — "/help"

FAQ — "/faq"

Terms of Service — "/legal/terms"

Privacy Policy — "/legal/privacy"

Cookie Policy & Consent Configuration — "/legal/cookies"

B. Authentication & Role Onboarding (12)
Sign Up — Role Selection — "/auth/signup/role"

Sign Up — Details (multi-step) — "/auth/signup/details"

Login — "/auth/login"

Password Reset — Request — "/auth/password-reset/request"

Password Reset — Set New Password — "/auth/password-reset/set"

Email Verification / Confirmation — "/auth/verify"

Two-Factor Auth Setup (optional page) — "/auth/2fa-setup"

Onboarding Wizard — Farmer — "/onboard/farmer"

Onboarding Wizard — Final Seller — "/onboard/seller"

Onboarding Wizard — Transporter — "/onboard/transporter"

Onboarding Wizard — Cargo Sender/Receiver — "/onboard/cargo"

Onboarding Wizard — Agricultural Engineer — "/onboard/engineer"

C. Dashboards (6) — role-specific overview dashboards
Dashboard — Farmer — "/dashboard/farmer"

Dashboard — Final Seller — "/dashboard/seller"

Dashboard — Transporter — "/dashboard/transporter"

Dashboard — Cargo Sender — "/dashboard/sender"

Dashboard — Cargo Receiver — "/dashboard/receiver"

Dashboard — Agricultural Engineer — "/dashboard/engineer"

D. Marketplace — Products (15)
Product Category Listing — "/market/:category"

Product Search Results — "/market/search?q="

Seller Product List (store manager) — "/seller/products"

Product Create — multi-step — "/seller/products/new"

Product Edit — "/seller/products/:id/edit"

Product Detail — "/product/:id"

Seller Storefront (public) — "/store/:sellerId"

Cart — "/cart"

Checkout (supports PazarPara + external payment) — "/checkout"

Order Confirmation / Receipt — "/order/:id/confirmation"

Buyer Orders List — "/orders"

Seller Sales List — "/seller/orders"

Order Detail (shipment + invoice) — "/orders/:id"

Returns & Refund Request — "/orders/:id/return"

Dispute / Case Management (buyer) — "/support/dispute/:id"

E. Transport & Jobs (12)
Transport Jobs List / Marketplace — "/jobs/transport"

Transport Job Create — multi-step — "/jobs/transport/new"

Transport Job Detail — "/jobs/transport/:id"

Submit Bid / Offer (job-specific modal/page) — "/jobs/transport/:id/bid"

Bid Management (poster view) — "/jobs/transport/:id/bids"

Assigned Jobs / In-Progress (transporter) — "/jobs/assigned"

Delivery Tracking (live map with route) — "/tracking/:jobId"

Proof of Delivery (upload images/signature) — "/jobs/:id/proof"

Job Completion Confirmation (sender/receiver sign-off) — "/jobs/:id/complete"

Job History / Past Jobs — "/jobs/history"

Transporter Earnings & Payouts — "/transporter/earnings"

Job-specific Chat / Negotiation (integrated message thread) — "/jobs/:id/chat"

F. Community & Social (10)
Community Feed / Timeline — "/community"

Create Post (with media) — "/community/new"

Post Detail & Comments — "/community/:postId"

Forum / Discussion Topics List — "/forum"

Forum Topic Detail — "/forum/:topicId"

Direct Messages — Inbox List — "/messages"

Conversation View — "/messages/:conversationId"

Followers / Following List — "/profile/:userId/followers"

Notifications Center (all notifications) — "/notifications"

Notification Settings — "/settings/notifications"

G. PazarPara Wallet & Rights (13)
Wallet Overview (balance + quick actions) — "/wallet"

Buy PazarPara — Packages page — "/wallet/buy"

Payment Checkout (PazarPara purchase) — "/wallet/checkout"

Payment Success — "/wallet/checkout/success"

Payment Failure / Retry — "/wallet/checkout/failure"

Transaction History — "/wallet/transactions"

Commission Breakdown (how 1% is applied) — "/wallet/commissions"

Rights (Hak) Catalog (available role-rights) — "/rights"

Rights Purchase Flow — "/rights/checkout"

Rights Management — active rights view — "/rights/active"

Withdrawals & Payout Requests (for sellers/transporters) — "/wallet/withdraw"

Invoices & Billing Info (downloadable invoices) — "/billing/invoices"

Billing Settings (tax, company info) — "/billing/settings"

H. Profiles & Settings (11)
Public User Profile (public view) — "/profile/:userId"

Edit Profile (personal info) — "/profile/edit"

Company / Business Profile Setup — "/profile/business-setup"

KYC / Identity Verification (document upload) — "/settings/kyc"

Account Settings (email / password) — "/settings/account"

Security & Active Sessions — "/settings/security"

Notification Preferences (duplicate safe guard) — "/settings/notifications" (ensure same as 68, but create a settings-UI version)

Language & Region Settings — "/settings/language"

Connected Apps & Integrations — "/settings/integrations"

Data & Privacy (data export / delete) — "/settings/privacy"

Developer / API Keys (if applicable) — "/settings/developer"

I. Admin & Moderation (19)
Admin Dashboard Overview — "/admin"

Admin — Users List — "/admin/users"

Admin — User Detail — "/admin/users/:id"

Admin — Roles & Rights Management — "/admin/roles"

Admin — PazarPara Packages Management — "/admin/pazarpara"

Admin — Commission Settings — "/admin/commissions"

Admin — Listings Moderation Queue — "/admin/listings"

Admin — Jobs Moderation Queue — "/admin/jobs"

Admin — Transaction Logs / Audit — "/admin/transactions"

Admin — Disputes & Refunds Queue — "/admin/disputes"

Admin — Reports & Analytics (sales, active users, revenue) — "/admin/reports"

Admin — System Settings & Maintenance — "/admin/settings"

Admin — Content Management (blog & pages) — "/admin/content"

Admin — Notification Composer (email/push) — "/admin/notifications"

Admin — Support Tickets — "/admin/support"

Admin — Audit Logs — "/admin/audit"

Admin — Marketing Banners Management — "/admin/banners"

Admin — Payment Gateway Configuration — "/admin/payment"

Admin — Security & Compliance Settings — "/admin/security"

J. Support & Extra (7)
Support Ticket Submission — "/support/new"

Live Chat (embedded widget view + history) — widget + "/support/chat"

Accessibility Statement & controls (text + toggles) — "/accessibility"

Integration Setup Guide (external partners) — "/integrations/guide"

API Documentation (developer facing) — "/api/docs"

Sandbox & Test Data (for QA) — "/dev/sandbox"

Release Notes / Changelog — "/changelog"

K. Errors, Templates & Component Pages (10)
404 Not Found — "/404"

500 Server Error — "/500"

Maintenance / Coming Soon — "/maintenance"

Empty State Templates (collection page showing patterns) — "/patterns/empty-states"

Loading Skeletons & Placeholders (collection) — "/patterns/loading"

UI Components Library / Design System Page — "/styleguide/components"

Confirmation Modals Template (design & variants) — "/patterns/modals"

Toasts & Alerts Template — "/patterns/toasts"

Guided Tours & Onboarding Tooltips (pattern page) — "/patterns/guided-tours"

Accessibility Overlay & High-Contrast / Large Text Mode toggle page — "/patterns/accessibility"

Specific business rules to enforce (repeat in relevant page specs)
PazarPara packages: 1, 5, 10, 20, 50, 100, 200 credits. Present as purchasable cards in "/pricing" and "/wallet/buy". Checkout must allow combination of PazarPara + external payment (partial).

Rights (Hak): Certain actions require purchasing a role-specific Right (e.g., to publish as a Farmer, to post transport jobs). Rights are purchased with PazarPara. Implement Rights catalog and flow.

Commissions: For Farmers, Final Sellers and Transporters, automatically charge 1% of relevant transaction volume in PazarPara. The UI must always show:

Gross price (payer sees)

Commission amount (explicit)

Net received (service provider sees)
Show commission breakdown on checkout, invoices, and transaction history.

Bidding (Transport Jobs): Job poster can accept one bid. Bids may have statuses (pending, accepted, rejected, counter-offer). Show bid history timeline. Allow messaging per bid.

Proof of delivery: Transporter must upload photos and optionally capture receiver signature; this is required to mark job complete.

Role-based dashboards: Dashboard content, quick actions, and KPIs are role-specific. Provide default widgets and allow drag-and-drop reordering (save layout per user).

Admin controls: Admin must be able to adjust PazarPara packages, set commission percentage, moderate listings/jobs, handle disputes, export transactions (CSV).

Payments: Support multiple payment providers; design payment method management page and fallback error handling.

Localization: Turkish primary. Show date/time in local format (DD.MM.YYYY). All currency shown in TL; allow currency switch in /settings/language.

Security: Provide pages for session management and 2FA. All financial flows require re-authentication (password or 2FA).

Prototype & deliverable checklist
For the whole product produce:

128 page specs following the exact template above.

Wireframes (desktop/tablet/mobile) for each page.

High-fidelity mockups (desktop/tablet/mobile) in Turkish (with English translation column).

Clickable prototype with annotated flows (all CTAs wired).

Component library + tokens JSON + exportable icons (SVG).

API contract suggestions (sample endpoints) for each page/form.

Sample test users (3 per role) and realistic sample data sets.

Analytics event map (global + page-specific events).

Accessibility audit checklist per page.

Exportable assets (PNG/SVG/WEBP) and measurement specs.

Final strict rules for UXpilot (important — do not ignore)
Create only the 128 pages listed above — no extras.

For each page, fully complete the Page Specification Template without exception.

Primary UI copy must be Turkish. Provide English translations in parallel.

Produce desktop, tablet and mobile variants for each page.

Provide file naming exactly as the convention described.

Provide API examples for all forms and data interactions.

Provide 3 realistic sample records for each list/detail screen (for prototyping).

Provide analytics events for every user action (CTA clicks, conversions, errors).

Produce a final single-sheet PDF index listing all 128 pages with their slugs and role access summary.

Do not make assumptions beyond what is written — if a decision is required and not specified, provide two explicit options inline and mark them as Option A / Option B; do not choose for us.