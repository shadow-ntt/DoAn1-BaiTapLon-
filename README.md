# 📋 Mục lục

1. [Hướng Dẫn Cấu Hình SQL Server Express Cho Phép Kết Nối Qua Mạng](#1-hướng-dẫn-cấu-hình-sql-server-express-cho-phép-kết-nối-qua-mạng)

## 1.Hướng Dẫn Cấu Hình SQL Server Express Cho Phép Kết Nối Qua Mạng

---

---

### 1.1. Bật TCP/IP cho SQL Server Express

Mặc định SQL Server Express tắt tính năng kết nối qua mạng. Bạn cần bật giao thức TCP/IP và cố định cổng 1433.

1. Nhấn **Windows + S**, tìm và mở **SQL Server Configuration Manager**.
2. Tại menu bên trái, điều hướng đến:
   `SQL Server Network Configuration` ➔ `Protocols for SQLEXPRESS`.
3. Chuột phải vào **TCP/IP** ➔ Chọn **Enable**.
4. Nhấp đôi chuột vào **TCP/IP** ➔ Chuyển sang tab **IP Addresses**:
   - Kéo xuống dưới cùng tìm mục **IPAll**.
   - Dòng **TCP Dynamic Ports**: **Xóa trống** (nếu đang có số `0` thì xóa đi).
   - Dòng **TCP Port**: Nhập **`1433`**.
   - Bấm **OK**.
5. Chọn mục **SQL Server Services** ở menu bên trái ➔ Chuột phải vào **SQL Server (SQLEXPRESS)** ➔ Chọn **Restart**.

---

### 1.2. Thiết lập Tài khoản Đăng nhập & Phân quyền

#### Bước 1: Mở khóa & Cập nhật mật khẩu chuẩn cho tài khoản `thailo`

Chạy đoạn SQL này trên Query Window để đặt lại mật khẩu thành `123456`, bỏ qua quy tắc mật khẩu phức tạp của Windows và unlock tài khoản:

```sql
USE [master]
GO

-- Reset mật khẩu và tắt kiểm tra chính sách mật khẩu phức tạp
ALTER LOGIN [thailo] WITH PASSWORD = N'123456', CHECK_POLICY = OFF, CHECK_EXPIRATION = OFF;
GO

-- Mở khóa và cho phép đăng nhập
ALTER LOGIN [thailo] ENABLE;
GO
```

#### Bước 2: Bật chế độ Mixed Mode (SQL Server and Windows Authentication)

Chạy lệnh can thiệp Registry sau để ép SQL Server bật chế độ đăng nhập bằng tài khoản SQL (User/Password):

```sql
EXEC xp_instance_regwrite
    N'HKEY_LOCAL_MACHINE',
    N'Software\Microsoft\MSSQLServer\MSSQLServer',
    N'LoginMode',
    REG_DWORD,
    2;
GO
```

#### Bước 3: Cấp quyền Full (db_owner) cho `thailo` vào `lavitadb`

Đảm bảo user này được ánh xạ và có quyền Admin trên database `lavitadb`:

```sql
USE [lavitadb]
GO
-- Tạo User trong database nếu chưa tồn tại
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'thailo')
BEGIN
    CREATE USER [thailo] FOR LOGIN [thailo]
END
GO

-- Cấp quyền Admin (db_owner) trên database lavitadb
ALTER ROLE [db_owner] ADD MEMBER [thailo];
GO
```

---

### 1.3. Mở Cổng 1433 trên Tường lửa (Windows Firewall)

Nếu không mở cổng 1433, Windows Defender Firewall sẽ chặn các máy tính khác kết nối vào SQL Server.

1. Nhấn **Windows + R**, gõ **`wf.msc`** rồi ấn **Enter** (để mở _Windows Defender Firewall with Advanced Security_).
2. Chọn **Inbound Rules** (ở danh mục bên trái) ➔ Bấm **New Rule...** (ở cột tác vụ bên right).
3. Chọn loại Rule: **Port** ➔ Bấm **Next**.
4. Chọn **TCP**, tại mục **Specific local ports** nhập **`1433`** ➔ Bấm **Next**.
5. Chọn **Allow the connection** ➔ Bấm **Next**.
6. Đánh dấu chọn đủ cả 3 ô (**Domain**, **Private**, **Public**) ➔ Bấm **Next**.
7. Đặt tên Rule: **`SQL Express 1433`** ➔ Bấm **Finish**.

---

### 1.4. Sửa lại chuỗi kết nối

```C#
    string connectionString = @"Server=172.31.143.125;Database=lavitadb;User Id=thailo;Password=123456;TrustServerCertificate=True;Pooling=False;";
```

### 1.5. Khởi động lại SQL Server Service

⚠️ **CỰC KỲ QUAN TRỌNG:** Sau khi hoàn thành các bước trên, bạn **bắt buộc phải Restart dịch vụ SQL Server** để toàn bộ cấu hình mới có hiệu lực.

1. Nhấn **Windows + R**, gõ **`services.msc`** và ấn **Enter**.
2. Tìm dịch vụ **SQL Server (SQLEXPRESS)** hoặc **SQL Server (MSSQLSERVER)**.
3. Chuột phải vào dịch vụ đó ➔ Chọn **Restart**.
