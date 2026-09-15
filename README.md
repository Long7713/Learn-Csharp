# Cẩm nang C# Cơ bản

## 1. Lệnh tương tác với Terminal (Lớp Console)

Lớp `Console` chứa các phương thức cốt lõi để nhận dữ liệu từ người dùng và in kết quả ra màn hình.

| Lệnh                  | Ý nghĩa và Cách hoạt động                                  | Ví dụ                             |
| :-------------------- | :--------------------------------------------------------- | :-------------------------------- |
| `Console.Write()`     | In chuỗi ra màn hình (không tự xuống dòng).                | `Console.Write("Nhập tên: ");`    |
| `Console.WriteLine()` | In chuỗi ra màn hình và **tự động xuống dòng**.            | `Console.WriteLine("Xin chào!");` |
| `Console.ReadLine()`  | Dừng chương trình chờ người dùng nhập và nhấn Enter.       | `string s = Console.ReadLine();`  |
| `Console.ReadKey()`   | Đọc ngay một ký tự vừa bấm (thường dùng để dừng màn hình). | `Console.ReadKey();`              |

---

## 2. Kiểu dữ liệu Bool và Toán tử logic

Kiểu `bool` chỉ nhận 2 giá trị: `true` (Đúng) hoặc `false` (Sai).

### 2.1. Toán tử thường dùng

| Phân loại     |             Ký hiệu              | Ý nghĩa                                             | Ví dụ (Kết quả = true) |
| :------------ | :------------------------------: | :-------------------------------------------------- | :--------------------- | ---------------------------------------------------------- | -------- | --- | --------- |
| **So sánh**   | `==`, `!=`, `>`, `<`, `>=`, `<=` | So sánh độ lớn hoặc tính bằng nhau.                 | `5 >= 3`               |
| **Logic AND** |               `&&`               | VÀ: Chỉ trả về `true` khi **tất cả** đều đúng.      | `(5 > 3) && (4 == 4)`  |
| **Logic OR**  |                `                 |                                                     | `                      | HOẶC: Trả về `true` khi có **ít nhất một** điều kiện đúng. | `(5 > 3) |     | (10 < 0)` |
| **Logic NOT** |               `!`                | PHỦ ĐỊNH: Đảo ngược giá trị (`true` thành `false`). | `!(5 == 4)`            |

---

## 3. Các phương thức kiểm tra trả về Bool phổ biến

Các hàm này thường được đặt trong câu lệnh `if` để kiểm tra điều kiện.

| Đối tượng  | Cú pháp                           | Ý nghĩa và Ứng dụng thực tế                                                                                                      |
| :--------- | :-------------------------------- | :------------------------------------------------------------------------------------------------------------------------------- |
| **String** | `string.IsNullOrEmpty(text)`      | Kiểm tra chuỗi bị rỗng (`""`) hoặc `null`. Dùng để bắt lỗi người dùng bỏ trống ô nhập liệu.                                      |
| **String** | `text.Contains("abc")`            | Kiểm tra xem chuỗi có chứa đoạn ký tự `"abc"` hay không (có phân biệt hoa thường).                                               |
| **Number** | `int.TryParse(chuoi, out int so)` | Ép kiểu chuỗi thành số an toàn. Trả về `true` (và gán kết quả vào `so`) nếu thành công. Nếu người dùng nhập sai, trả về `false`. |
