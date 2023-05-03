using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaMVVM.Model
{
    public class UserModel
    {

        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }

        [MaxLength (10)]
        public string User { get; set; }

        [MaxLength(20)]
        public string Nombre { get; set; }

        [MaxLength(10)]
        public string Pw { get; set; }

    }
}
