public class Job
{
    //Responsabilities: Keeps track of the company, job title, start year, and end year.
    //Behaviors: Displays the job information in the format "Job Title (Company) StartYear-EndYear",
    //for example: "Software Engineer (Microsoft) 2019-2022".

    public string _company;
    public string _jobTitle;
    public int startYear;
    public int endYear;

    public Job()
    {
    }

    public void Display()
    {
         Console.WriteLine($"{_jobTitle} ({_company}) {startYear}-{endYear}");
    }
}