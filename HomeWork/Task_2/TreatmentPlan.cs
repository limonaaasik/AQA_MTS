namespace HomeWork
{
    public class TreatmentPlan
    {
        public int treatPlanID;

        public TreatmentPlan(int treatPlanID)
        {
            this.treatPlanID = treatPlanID;
        }

        public Doctor AppointDoctor()
        {

            switch (treatPlanID)
            {
                case 1: return new Surgeon();
                case 2: return new Dentist();
                default: return new Therapist();

            }

        }
    }
}
