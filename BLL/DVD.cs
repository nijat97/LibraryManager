using System;

namespace LibraryManager.BLL
{
    public class DVD : Item
    {
        public Director director { get; set; }

        public DVD(String title, int barcode, Director director) : base(title, barcode)
        {
            this.director = director;
        }
    }
}
