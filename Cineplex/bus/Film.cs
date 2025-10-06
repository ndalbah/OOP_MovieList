using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cineplex.bus
{
    public class Film : Object
    {
        private int code;
        private string? title;
        private EnumCategory category;
        private EnumLanguage language;
        private Person actor;
        private Time duration;

        public int Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public EnumCategory Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        public EnumLanguage Language
        {
            get { return this.language; }
            set { this.language = value; }
        }

        public Person Actor
        {
            get { return this.actor; }
            set { this.actor = value; }
        }

        public Time Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        public Film()
        {
            this.code = 0;
            this.title = "Undefined";
            this.category = EnumCategory.UNDEFINED;
            this.language = EnumLanguage.UNDEFINED;
            this.actor = new Person();
            this.duration = new Time();
        }

        public Film(int code, string title, EnumCategory category, EnumLanguage language, Person actor, Time duration)
        {
            this.code = code;
            this.title = title;
            this.category = category;
            this.language = language;
            this.actor = actor;
            this.duration = duration;
        }

        public string GetFilmState()
        {
            string state;
            state = this.code + "|" + this.title + "|" + this.category + "|" + this.language + "|" + this.actor + "|" + this.duration;

            return state;
        }

        public override string ToString()
        {
            string state;
            state = this.code + "|" + this.title + "|" + this.category + "|" + this.language + "|" + this.actor + "|" + this.duration.GetTimeState();

            return state;

        }

    }
}
