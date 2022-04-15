using System;
using System.Collections.Generic;

namespace LibraryManager.BLL
{
    public sealed class DVDStore : ItemSearch<DVD>
    {
        public List<DVD> DVDs { get; set; }

        private static readonly DVDStore instance = new DVDStore();

        static DVDStore()
        {

        }

        private DVDStore()
        {
            DVDs = new List<DVD>();
        }

        public static DVDStore Instance
        {
            get
            {
                return instance;
            }
        }

        public List<DVD> SearchByBarcode(int barcode)
        {
            throw new NotImplementedException();
        }

        public List<DVD> SearchByTitle(string title)
        {
            throw new NotImplementedException();
        }

        List<DVD> SearchDVDByDirectorName(String name)
        {
            return DVDs.FindAll(i => i.director.name == name);
        }

        List<DVD> SearchDVDByDirectorNationality(String nationality)
        {
            return DVDs.FindAll(i => i.director.nationality == nationality);
        }

        List<DVD> SearchDVDByDirectorBirthDate(DateTime birthDate)
        {
            return DVDs.FindAll(i => i.director.birthDate == birthDate);
        }

        public void AddNewDVD(String title, int barcode, Director director)
        {
            if (!DVDs.Exists(i => i.barcode == barcode))
            {
                DVD dvd = new DVD(title, barcode, director);
                DVDs.Add(dvd);
            }
        }

        public void RemoveDVD(DVD dvd)
        {
            if (DVDs.Contains(dvd))
            {
                _ = DVDs.Remove(dvd);
            }
        }
    }
}
