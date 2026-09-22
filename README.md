# ThreadLine — Clothing Store Customer Management System

**ITE Electronic Machine Problem 1-1**
ASP.NET MVC + AngularJS. Customer registration with full client-side CRUD
(in-memory AngularJS array — no database).

## Tech Stack
- ASP.NET MVC 5 / C#
- AngularJS 1.8.2
- Materialize CSS + Tailwind CSS
- SweetAlert2

## Pages
| Page | Route | View |
|---|---|---|
| Login | `/Main/LoginPage` | `Views/Main/LoginPage.cshtml` |
| Registration | `/Main/RegistrationPage` | `Views/Main/RegistrationPage.cshtml` |
| Home | `/Main/Index` | `Views/Main/Index.cshtml` |
| About | `/Main/AboutPage` | `Views/Main/AboutPage.cshtml` |
| Contact | `/Main/ContactPage` | `Views/Main/ContactPage.cshtml` |

The default route lands on `Main/LoginPage`. All pages share `Views/Shared/_MainLayout.cshtml`
(via `Views/_ViewStart.cshtml`).

## Registration fields
Customer ID, Username, First Name, Middle Name, Last Name, Suffix, Email Address,
Password, Confirm Password, Contact Number, Gender, Birthday, Address.

## Validation implemented (`Scripts/HolyScripts/Controller.js`)
| Type | Where |
|---|---|
| Required field | all mandatory fields |
| Maximum length | Customer ID 10, names 50, suffix 10, username 20, email/password 254, address 200 |
| Email format | `^[^\s@]+@[^\s@]+\.[^\s@]+$` |
| Contact number format | `^09\d{9}$` (starts with 09, exactly 11 digits) |
| Password strength | 8+ chars, uppercase, lowercase, number, special character |
| Confirm password | must match Password |
| Numeric | Customer ID must be digits only |
| Range | Birthday cannot be a future date |
| Pattern / Regex | see email, contact, password, numeric above |
| Uniqueness | Customer ID, Username, Email (skips the row being edited) |
| Custom | birthday future-date rule |
| Feedback | meaningful SweetAlert2 messages for every rule |

> Minimum-length validation was intentionally omitted; the password rule already enforces a
> minimum length of 8 characters.

## CRUD (AngularJS array)
- **CREATE** — `registrationFunc()` validates, builds the customer object, pushes it into `$scope.customerArray`
- **READ** — the "Registered Customers" table renders `customerArray` with `ng-repeat` and an **Action** column
- **UPDATE** — `editFunc($index)` loads the row into the form (the title and subtitle switch to editing mode);
  either the form's **Update Customer** button (`updateFunc(editingIndex)`) or the row's **Update** button
  (`updateFunc($index)`) writes the changes back, and the table updates
- **DELETE** — `deleteFunc($index)` asks for confirmation with SweetAlert2, then removes the record
  (`$scope.$apply` so the table refreshes)

## Controller → View data flow
`MainController.GetWelcomeMessage()` returns JSON → `Service.js` fetches it with `$http` →
`Controller.js` stores it in `$scope.welcomeMessage` → `Index.cshtml` renders `{{ welcomeMessage }}`.

## How to run
1. Open `ITEWebApplicationProject.slnx` in Visual Studio
2. Build the solution (`Ctrl+Shift+B`)
3. Press `F5`
4. The default route lands on `Main/LoginPage`

## Placeholders still to replace

| Where | Placeholder | Replace with |
|---|---|---|
| `Views/Main/ContactPage.cshtml` | `support@threadline.example` | real support email |
| `Views/Main/ContactPage.cshtml` | `0917 000 0000` | real phone number |
| `Views/Main/ContactPage.cshtml` | `123 Fashion Street, Manila, Philippines` | real store address |
| `Views/Main/ContactPage.cshtml` | `@ThreadLinePH` / `@threadline.ph` | real social handles |
| `Views/Main/AboutPage.cshtml` | team member name | set to **Rick Andrie R. Rocio** |
| `Controllers/MainController.cs` | `"Welcome to ThreadLine Clothing Store!"` | store name if it changes |
| `Views/Shared/_MainLayout.cshtml` | `ThreadLine` brand, `<title>`, footer text | store name if it changes |
| `Views/Main/Index.cshtml` | ThreadLine welcome copy | store name if it changes |
| Solution / folder | `ITEWebApplicationProject_Santos` | confirm the required name with the professor |

## Notes
- No database: records live in an AngularJS array and reset on a full page reload (expected).
- Bootstrap is **not** used as the primary CSS framework (the Bootstrap bundle registration was removed
  from `BundleConfig.cs`); the unused Bootstrap package files remain on disk but are never referenced.
- Contact details in `ContactPage.cshtml` are **placeholders** — replace them with real ones.
