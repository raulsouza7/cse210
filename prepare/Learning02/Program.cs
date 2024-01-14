using System;

class Program
{
    static void Main(string[] args)
    {

        // Create job instances
        Job job1 = new Job { _company = "Microsoft", _jobTitle = "Software Engineer", _startYear = 2019, _endYear = 2022 };
        Job job2 = new Job { _company = "Apple", _jobTitle = "Manager", _startYear = 2022, _endYear = 2023 };

        // Create resume instance
        Resume resume = new Resume { _personName = "Allison Rose" };
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Display resume
        resume.Display();
    }
}
