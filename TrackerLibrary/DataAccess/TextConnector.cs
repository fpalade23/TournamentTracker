using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";

        /// <summary>
        /// Saves a new person in the text file.
        /// </summary>
        /// <param name="model">The people information.</param>
        /// <returns>The people information, including the unique identifier.</returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            // Load the text file and convert the text to List<PrizeModel>
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            // Find the max id
            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the new record with the new id (max+1)
            people.Add(model);

            // Convert the people to a list<string>
            // save the list<string> to text file
            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        /// <summary>
        /// Saves a new prize in the text file.
        /// </summary>
        /// <param name="model">The prizes information.</param>
        /// <returns>The prizes information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file and convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max id
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the new record with the new id (max+1)
            prizes.Add(model);

            // Convert the prizes to a list<string>
            // save the list<string> to text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        /// <summary>
        /// Get the people from the text file
        /// </summary>
        /// <returns>A list of people</returns>
        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }
    }
}
