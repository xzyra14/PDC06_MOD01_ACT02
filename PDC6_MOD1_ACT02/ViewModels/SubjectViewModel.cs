using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using PDC6_MOD1_ACTIVITY02.Models;

namespace PDC6_MOD1_ACTIVITY02.ViewModels
{
    class SubjectViewModel
    {
        public Subject SubjectSet { get; set; }

        public SubjectViewModel()
        {
            SubjectSet = new Subject
            {
                SubjectCode = "PDC6",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3,
            };
        }
    }
}
