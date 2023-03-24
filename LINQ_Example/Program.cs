

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Candidate[] candidateArray = {
            new Candidate() { CandidateID = 1, CandidateName = "John", Age = 18 },
            new Candidate() { CandidateID = 2, CandidateName = "Steve",  Age = 21 },
            new Candidate() { CandidateID = 3, CandidateName = "Bill",  Age = 25 },
            new Candidate() { CandidateID = 4, CandidateName = "Ram" , Age = 20 },
            new Candidate() { CandidateID = 5, CandidateName = "Ron" , Age = 31 },
            new Candidate() { CandidateID = 6, CandidateName = "Chris",  Age = 17 },
            new Candidate() { CandidateID = 7, CandidateName = "Rob",Age = 19  },
        };

            //Looping Method
            //Candidate[] candidates = new Candidate[10];

            //int index = 0;

            //foreach (Candidate cd in candidateArray)
            //{
            //    if (cd.Age > 18)
            //    {
            //        candidates[index] = cd;
            //        index++;
            //    }
            //}

            // LINQ Query Syntax

            //var EligibleCandidates = from candidate in candidateArray
            //                         where (candidate.Age > 18)
            //                         select candidate;

            //LINQ Method Syntax
            var EligibleCandidates = candidateArray.Where(candidate => candidate.Age > 18).ToList();
            var OrderedCandidates = EligibleCandidates.OrderBy(candidate => candidate.CandidateName);

            foreach (var candidate in OrderedCandidates)
            {
                Console.WriteLine(candidate.CandidateName);
            }

            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            IEnumerable<int> filteringQuery = from number in numbers
                                              where number < 3 || number > 7
                                              select number;
            double average = numbers.Average();
            Console.ReadLine();
        }
    }
}
