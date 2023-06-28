using Microsoft.AspNetCore.Mvc;

namespace HomeTask_24.Controllers
{
    public class GroupController : ControllerBase
    {
        private static List<string> cachedGroups = new List<string>();

        [HttpPost]
        public IActionResult Post([FromBody] Group group)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!IsValidGroupName(group.Name))
            {
                return BadRequest("Invalid group name. It should consist of 2-5 characters.");
            }

            if (string.IsNullOrWhiteSpace(group.Name))
            {
                return BadRequest("Group name cannot be empty or contain only whitespace.");
            }

            if (group.Course <= 0 || group.Course >= 7)
            {
                return BadRequest("Invalid course value. It should be a positive number less than 7.");
            }

            if (!IsValidGroupNameFormat(group.Name))
            {
                return BadRequest("Invalid group name format. It should be in the format 'three letters - two digits'.");
            }


            if (cachedGroups.Count == 0)
            {
                cachedGroups = FetchGroups();
            }

            return Ok(cachedGroups);
        }

        private bool IsValidGroupName(string name)
        {
            return name.Length >= 2 && name.Length <= 5;
        }

        private bool IsValidGroupNameFormat(string name)
        {
            if (name.Length != 6)
            {
                return false;
            }

            string letters = name.Substring(0, 3);
            string digits = name.Substring(4, 2);

            return letters.All(char.IsLetter) && digits.All(char.IsDigit) && name[3] == '-';
        }

        private List<string> FetchGroups()
        {
            return new List<string> { "Group A", "Group B", "Group C" };
        }
    }
}
