using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_Examples.Components.AddQuestionUI.Models
{
    public class Question
    {
        public string Name { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
