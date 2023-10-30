Luôn pull code mới nhất từ nhánh chính về trước khi bắt đầu làm việc. Tránh xung đột code sau này.
Tạo nhánh mới để làm tính năng hoặc fix bug. Đặt tên nhánh có ý nghĩa với nội dung công việc. Ví dụ: feature/login, fix/comment-error
Commit thường xuyên với message có ý nghĩa. Mỗi commit nên là 1 ý tưởng nhỏ, không nên quá lớn.
Không commit trực tiếp lên nhánh chính. Luôn tạo pull request để những người khác review code trước khi merge.
Xóa nhánh local và remote sau khi đã merge pull request thành công.
Giữ cho lịch sử commit sạch sẽ, tránh những commit không cần thiết. Có thể dùng git rebase để tổ chức lại.
Luôn pull code mới nhất từ remote repository trước khi push lên. Điều này giảm thiểu xung đột.
Sử dụng git tag để đánh dấu các phiên bản quan trọng.
