using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pecs.state
{
    static class Topic
    {
        public static FormName topicForm = FormName.Login;

        public static Image advancedPickedImage;
        public static FormName advancedNextFormName;

        public static class Topic13State
        {
            public static Image chosenImage;
        }

        public static class Topic33State
        {
            public static Image chosenImage;
        }

        // ReSharper disable once ArrangeModifiersOrder
        static public class Topic22State
        {
            public static String T = "";
            public static String T2 = "";
            public static String totalQuestion = "";
            public static Image chosenImage;
        }

        public static class Topic43State
        {
            public static String T = "";
            public static String T2 = "";
            public static String totalQuestion = "";
            public static Image chosenImage;
        }

        public static class Topic58State
        {
            public static Image chosenImage;
        }

        public static class Topic68State
        {
            public static String totalQuestion = "";
            public static Image chosenImage;
        }

        public static class Topic78State
        {
            public static List<String> regList = new List<string>();
            public static String T = "";
            public static String T2 = "";
            public static String totalQuestion = "";
            public static Image chosenImage;
        }
    }
}