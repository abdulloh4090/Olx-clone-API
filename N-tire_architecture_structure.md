📁 1. MyProject.API (Presentation Layer)

Bu foydalanuvchi va tizim o‘rtasidagi interfeys. API endpointlar shu yerda.

🔸 Nima joylashadi:
Controllers/ — API endpointlar
<br>
  DTOs/ — CreateDto, UpdateDto, ResponseDto<br>
  Program.cs, Startup.cs — DI, middleware
  Mappers/ — AutoMapper profillari
  Filters/ — Global exception handling, validation filters
  SwaggerConfig/ — Swagger setup (istalgancha sozlash)

📁 2. MyProject.Application (Business Logic Layer)

Bu qatlamda butun biznes qoidalari bo‘ladi.

🔸 Nima bo‘ladi:
  Interfaces/ — Servis interfeyslar: IUserService, IAdService
  Services/ — Business logic implementatsiyasi
  DTOs/ — Loyihaga tegishli DTO'lar
  Validators/ — FluentValidation classlari
  Exceptions/ — Custom exceptionlar (masalan, NotFoundException)
  Common/ — Helperlar, Response classlar, PagedResult, Constants

📁 3. MyProject.Domain (Entities Layer)

Bu qatlamda core business modeli, ya’ni Entitylar, Enums bo‘ladi. Boshqa qatlamlar Domain’ga bog‘liq bo‘ladi, lekin Domain hech kimga bog‘lanmaydi.

🔸 Nima joylashadi:
  Entities/ — User, Ad, Category, Comment...
  Enums/ — Status, Role, Gender...
  ValueObjects/ — Email, Address, PhoneNumber...
  Base/ — BaseEntity, AuditableEntity (CreatedDate, ModifiedDate)
  Interfaces/ — Ba’zan Domain eventlar, IAggregateRoot

📁 4. MyProject.Infrastructure (Data Access Layer)

Bu qatlam ma’lumotlar bazasi bilan bog‘liq harakatlarni bajaradi.

🔸 Nima joylashadi:
  Persistence/ — AppDbContext, konfiguratsiyalar
  Repositories/ — AdRepository, UserRepository
  Configurations/ — EF Fluent API map classlari
  Migrations/ — EF Migrations (automatik bo‘lishi mumkin)
  Seed/ — Dastlabki ma'lumotlar
  Identity/ — Agar Identity ishlatsangiz

📦 Yordamchi papkalar (hamma qatlamlar uchun foydali):

Papka nomi	              Vazifasi
Common/	            Reusable helpers, ApiResponse, PaginatedList
Exceptions/	        Custom exceptionlar
Mappers/	          AutoMapper profillari
Validators/	        DTO validation

✅ Layerlararo bog‘lanish (Dependency flow):

MyProject.API (Controllers, DTOs)
      ↓
MyProject.Application (Services, Interfaces, Business Logic)
      ↓
MyProject.Infrastructure (Repositories, DbContext)
      ↓
MyProject.Domain (Entities, Enums)

Muhim: Har bir qatlam faqat quyidagi qatlamga bog‘lanadi, yuqoriga emas!




