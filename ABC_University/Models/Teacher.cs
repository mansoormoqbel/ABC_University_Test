﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ABC_University.Models
{
    public class Teacher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int teacherID { get; set; }
        public string teacherName { get; set; }
        public string teacherNumber { get; set; }
    }
}