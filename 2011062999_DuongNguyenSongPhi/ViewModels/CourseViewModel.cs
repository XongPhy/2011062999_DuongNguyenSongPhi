using _2011062999_DuongNguyenSongPhi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace _2011062999_DuongNguyenSongPhi.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
        public DateTime GetDateTime()
        {
            DateTime result;
            if (DateTime.TryParseExact(string.Format("{0} {1}", Date, Time), "dd/M/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                return result;
            }
            else
            {
                // không thể chuyển đổi, xử lý lỗi ở đây
                return DateTime.MinValue; // hoặc trả về giá trị mặc định khác tùy thuộc vào yêu cầu của bạn
            }
        }
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}