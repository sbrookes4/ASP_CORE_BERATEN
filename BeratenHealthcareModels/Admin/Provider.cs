//namespace BeratenHealthcareModels
//{
//    public class Provider
//    {
//        public int Id { get; set; }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string Suffix { get; set; }
//        public string CellPhone { get; set; }
//        public string OtherPhone { get; set; }

//        public string DisplayName
//        {
//            get
//            {
//                return string.Format("{0}{1}{2}",
//                    (FirstName != null ? FirstName + " " : null),
//                    (LastName != null ? LastName + " " : null),
//                    (Suffix != null ? ", " + Suffix : null)
//                    ).Trim();
//            }
//        }

//        public override string ToString()
//        {
//            return Id + ": " + DisplayName;
//        }
//    }
//}