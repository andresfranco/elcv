﻿using ELCV.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELCV.Core.Entities
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PicturePath { get; set; }
        public ICollection<Resume> Resumes { get; set; }
        public List<PersonSkill> PersonSkills { get; set; }
    }
}