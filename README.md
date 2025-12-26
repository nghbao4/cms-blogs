# CMS-BLOG  
Xây dựng hệ thống CMS Blog với **.NET 8 & Angular**

## 📌 Giới thiệu
**CMS-BLOG** là dự án thực tế xây dựng hệ thống **Content Management System (CMS)** cho Blog, sử dụng **.NET 8 (ASP.NET Core)** cho Backend và **Angular** cho Back Office (Admin).  
Dự án được thiết kế theo các **best practices hiện đại**, sát với môi trường doanh nghiệp và hướng tới Fullstack Developer.

Hệ thống bao gồm:
- **Admin (Back Office)**: Quản trị nội dung, người dùng, phân quyền
- **Portal (Website)**: Hiển thị blog, bài viết, đăng ký, đăng nhập, đăng bài

---

## 🧠 Công nghệ & Best Practices
- **.NET 8 (ASP.NET Core Web API, MVC)**
- **Angular + CoreUI**
- **Entity Framework Core**
- **ASP.NET Core Identity**
- **JWT Authentication (Access Token & Refresh Token)**
- **NSwag – Generate API Client**
- **Dapper (Raw SQL)**
- **MediatR**
- **AutoMapper**

### Kiến trúc & Design Pattern
- Clean Architecture  
- Distributed Architecture  
- Domain Driven Design (DDD)  
- Repository Pattern  
- Unit of Work  
- Dependency Injection  

**Tài liệu tham khảo**
- Clean Architecture: https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html  
- RESTful API: https://restfulapi.net/  
- DDD:  
  - https://learn.microsoft.com/en-us/archive/msdn-magazine/2009/february/best-practice-an-introduction-to-domain-driven-design  

---

## ✨ Tính năng chính

### 🔐 Admin (Angular)
- Quản lý Role & Permission
- Quản lý User (gán quyền, đổi email, reset mật khẩu)
- Quản lý danh mục bài viết
- Quản lý bài viết & series (workflow duyệt bài)
- Quản lý comment
- Quản lý nhuận bút & giao dịch
- Thống kê & báo cáo

### 🌐 Portal (ASP.NET Core MVC)
- Trang chủ, danh sách & chi tiết bài viết
- Hiển thị bài viết theo danh mục, tag, series
- Đăng ký / đăng nhập (Google, Facebook)
- Người dùng đăng bài
- Quản lý profile cá nhân
- Thống kê bài viết
- SEO Optimization

---

## 📂 Cấu trúc Solution
CMS-BLOG
│
├── CMS.Blog.Api # ASP.NET Core Web API
├── CMS.Blog.Core # Domain, Entities, Interfaces
├── CMS.Blog.Data # EF Core, Repositories, Migrations
├── CMS.Blog.Web # ASP.NET Core MVC (Portal)
└── cms-blog-admin # Angular Back Office


---

## 🚀 Lộ trình triển khai

### Chương 1: Tổng quan & Nền tảng
- MVC, RESTful API
- .NET Platform & ASP.NET Core
- EF Core, Identity
- Design Patterns
- Angular Framework
- Phân tích nghiệp vụ & thiết kế Database

### Chương 2: Xây dựng Backend Core
- Setup môi trường (.NET 8, SQL Server)
- Tạo Solution từ Scratch
- Identity + Migration + Seeding
- Repository & UnitOfWork
- Pagination, AutoMapper
- Test API

### Chương 3: Back Office (Angular)
- Angular CLI + CoreUI
- Authentication & Authorization (JWT)
- Permission-based Routing
- API Client với NSwag
- Quản lý user, role, category, post, series
- Workflow duyệt bài
- Quản lý nhuận bút (Dapper)
- Fix bugs & tối ưu

### Chương 4: Website người dùng
- ASP.NET Core MVC + Clean Blog UI
- PartialView, ViewComponent
- Nâng cấp .NET 8 chính thức
- Đăng ký, đăng nhập, profile
- Đăng bài, duyệt bài
- Tag, Series, SEO

### Chương 5: Deploy
- Deploy trên VPS (IIS)
- HTTPS, DNS, Migration
- Multi-environment config
- Monitoring & Fix lỗi

---

## 🧰 Yêu cầu môi trường

### Backend
- .NET SDK 8.0  
- Visual Studio 2022 (>= 17.8)
- SQL Server Developer
- SQL Server Management Studio

### Frontend
- NodeJS (LTS)
- Angular CLI
- Yarn
- Visual Studio Code

### Khác
- Git

---

## 👨‍🎓 Đối tượng học tập
- Sinh viên sắp tốt nghiệp, đang làm MVC / Web API
- Người đi làm muốn học **xây dựng hệ thống hoàn chỉnh**
- Lập trình viên muốn nâng cao tư duy kiến trúc

---

## 📚 Yêu cầu tối thiểu
- C# căn bản
- HTML, CSS, JavaScript căn bản
- SQL Server căn bản
- ASP.NET Core căn bản

---

## 👤 Tác giả
**BAONH4**