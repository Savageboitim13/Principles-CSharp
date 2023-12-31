namespace Dependency_Inversion {
    interface IChore {
        string ChoreName { get; set; }
        IPerson Owner { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }

        void PerformWork(double hours);

        void CompleteChore();
    }
}