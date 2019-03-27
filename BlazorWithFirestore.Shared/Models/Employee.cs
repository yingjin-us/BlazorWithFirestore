using System;
using Google.Cloud.Firestore;

namespace BlazorWithFirestore.Shared.Models
{
    /// <summary>
    /// Decorate class with [FirestoreData] will allow mapping this object to Firestore collection.
    /// Only properties marked with [FirestoreProperty] are considered when saving doc to collection
    /// </summary>
    [FirestoreData]
    public class Employee
    {
        public string EmployeeId { get; set; }
        public DateTime date { get; set; }
        [FirestoreProperty]
        public string EmployeeName { get; set; }
        [FirestoreProperty]
        public string CityName { get; set; }
        [FirestoreProperty]
        public string Designation { get; set; }
        [FirestoreProperty]
        public string Gender { get; set; }
    }
}