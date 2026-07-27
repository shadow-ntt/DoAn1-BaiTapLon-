# 📋 Mục lục

1. [Đề bài](#1-đề-bài)
2. [Kịch bản](#2-kịch-bản)
3. [Hướng Dẫn Cấu Hình SQL Server Express Cho Phép Kết Nối Qua Mạng](#3-hướng-dẫn-cấu-hình-sql-server-express-cho-phép-kết-nối-qua-mạng)

## 1. Đề bài

Công ty LAVITA có hệ thống xử lý đơn đặt hàng được mô tả như sau: Mỗi yêu cầu đặt hàng có dữ liệu cá nhân khách hàng (họ tên, số CMND, địa chỉ, mã bưu chính, thành phố, SĐT, mã số thuế, mức tín dụng) và dữ liệu đặt hàng (mã số đơn, ngày đặt hàng, ngày giao, mã hàng, tên hàng, số lượng, đơn giá). Khi nhận yêu cầu đặt hàng từ khách hàng, giao dịch viên đối chiếu dữ liệu khách hàng trong hồ sơ khách hàng; nếu cần, cập nhật dữ liệu mới từ khách hàng vào hồ sơ khách hàng, sau đó lưu đơn đặt hàng của khách hàng vào hồ sơ đặt hàng. Kiễm soát viên lấy đơn đặt hàng từ hồ sơ khách hàng, kiễm tra mức tín dụng của khách hàng trong hồ sơ khách hàng để xác định đơn có hợp lệ hay không. Kiễm soát viên cũng kiễm tra mức tồn kho của các món hàng được yêu cầu trong hồ sơ tồn kho để xác định các đơn đặt hàng không khả thi (kho không thể đáp ứng). Dữ liệu mô tả các món hàng trong kho gồm mã hàng, tên hàng, mô tả, loại hàng, số lượng tồn đầu kỳ). Các đơn đặt hàng hợp lệ và khả thi được lưu vào hồ sơ đặt hàng hợp lệ. Đơn không hợp lệ hoặc không khả thi được gửi trả về cho khách hàng cùng với lý do. Mỗi khách hàng do một kiễm soát viên phụ trách (có mã số KSV, tên, mức lương, mã số phòng, tên phòng). Hóa đơn bán hàng có tên khách hàng, mã số thuế, các khoản mục cần thanh toán lấy theo đơn đặt hàng, ngày lập hóa đơn. Kế toán viên lấy các đơn đặt hàng hợp lệ từ hồ sơ đặt hàng hợp lệ, lập hóa đơn bán hàng (2 bản), in tờ khai kiện hàng (ghi món hàng và số lượng sẽ đóng gói cho mỗi đơn đặt hàng), và lưu các hóa đơn, tờ khai kiện hàng và đơn đặt hàng vào hồ sơ đặt hàng hoàn chỉnh.
Nhân viên giao hàng nhận tờ khai kiện hàng, hóa đơn và đơn đặt hàng từ hồ sơ đặt hàng hoàn chỉnh để gửi yêu cầu xuất hàng đến nhà kho (gồm nội dung của đơn đặt hàng và ngày yêu cầu xuất kho), nhận hàng xuất từ kho, cập nhật lượng hàng xuất vào hồ sơ tồn kho, sau đó giao hàng, hóa đơn (1 bản) và tờ khai kiện hàng đến khách hàng để thu tiền. Các hóa đơn đã thu tiền được lưu vào hồ sơ doanh thu.

## 2. Kịch bản

1. nhân viên đăng nhập

- sai hoặc lỗi hệ thống thì thông báo
- đúng thì phân quyền cho từng chức năng của nhân viên

2. khách lên đơn hàng

- khách đưa thông tin CCCD
- ghv dựa vào đó để tìm kiếm

* nếu không tìm thấy thì thêm
* check thông tin còn lại của khách-> sai thì sửa lại
  -khách đưa thông tin mã hàng và số lượng
  -nhân viên bấm duyệt để chuyển qua cho kiểm soát viên

3. Kiểm soát viên check đơn

- nếu số lượng tồn kho thiếu hoặc vượt mức tín dụng thì báo lại cho khách ->nhập lý do và bấm từ chối
- nếu ok thì bấm duyệt để chuyển tới cho bộ phận kế toán để xử lý tiếp
  +số lượng tồn kho sẽ bị trừ từ đây

4. Kế toán

- in ra hóa đơn và tờ khai kiện hàng
- bấm hoàn thành in hóa đơn để phía giao hàng có thể thấy và đi đến bộ phận kế toán để xin giấy tờ cần thiết

5. giao hàng

- cầm hóa đơn và tờ khai kiện hàng đi tới kho để lấy hàng
- bắt đầu đi giao hàng

* nếu ok thì bấm hoàn thành
* trường hợp khách bùng thì bấm hoàn trả hàng để chuyển tới bộ phận kho
  6.Bộ phận kho
  +trường hợp hoàn hàng, thì sau khi chứng minh được đơn hàng để hoàn hàng thì nhân viên kho bấm hoàn trả hàng và chuyển hàng vào lại trong kho

## 3. Hướng Dẫn Cấu Hình SQL Server Express Cho Phép Kết Nối Qua Mạng

---

---

### 3.1. Bật TCP/IP cho SQL Server Express

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

### 3.2. Thiết lập Tài khoản Đăng nhập & Phân quyền

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

### 3.3. Mở Cổng 1433 trên Tường lửa (Windows Firewall)

Nếu không mở cổng 1433, Windows Defender Firewall sẽ chặn các máy tính khác kết nối vào SQL Server.

1. Nhấn **Windows + R**, gõ **`wf.msc`** rồi ấn **Enter** (để mở _Windows Defender Firewall with Advanced Security_).
2. Chọn **Inbound Rules** (ở danh mục bên trái) ➔ Bấm **New Rule...** (ở cột tác vụ bên right).
3. Chọn loại Rule: **Port** ➔ Bấm **Next**.
4. Chọn **TCP**, tại mục **Specific local ports** nhập **`1433`** ➔ Bấm **Next**.
5. Chọn **Allow the connection** ➔ Bấm **Next**.
6. Đánh dấu chọn đủ cả 3 ô (**Domain**, **Private**, **Public**) ➔ Bấm **Next**.
7. Đặt tên Rule: **`SQL Express 1433`** ➔ Bấm **Finish**.

---

### 3.4. Sửa lại chuỗi kết nối

```C#
    string connectionString = @"Server=172.31.143.125;Database=lavitadb;User Id=thailo;Password=123456;TrustServerCertificate=True;Pooling=False;";
```

### 3.5. Khởi động lại SQL Server Service

⚠️ **CỰC KỲ QUAN TRỌNG:** Sau khi hoàn thành các bước trên, bạn **bắt buộc phải Restart dịch vụ SQL Server** để toàn bộ cấu hình mới có hiệu lực.

1. Nhấn **Windows + R**, gõ **`services.msc`** và ấn **Enter**.
2. Tìm dịch vụ **SQL Server (SQLEXPRESS)** hoặc **SQL Server (MSSQLSERVER)**.
3. Chuột phải vào dịch vụ đó ➔ Chọn **Restart**.
