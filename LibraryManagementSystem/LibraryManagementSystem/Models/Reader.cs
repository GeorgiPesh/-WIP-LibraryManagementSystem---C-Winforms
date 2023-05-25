using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Reader
    {
        private int id;
        private string name;
        private string email;
        private string phonenumber;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Reader Name")]
        [Required(ErrorMessage = "Reader name is required")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DisplayName("Reader Email")]
        [Required(ErrorMessage = "Reader email is required")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DisplayName("Reader Phone")]
        [Required(ErrorMessage = "Reader phone is required")]
        public string PhoneNumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

    }
}
