using HomeTask_20;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

public class UsersController : ApiController
{
    private List<User> users;

    public UsersController()
    {
        users = new List<User>();
    }

    public IEnumerable<User> Get()
    {
        return users;
    }

    public IHttpActionResult Get(string name)
    {
        var user = users.FirstOrDefault(u => u.Name == name);
        if (user == null)
            return NotFound();

        return Ok(user);
    }

    public IHttpActionResult Post(User user)
    {
        if (!ModelState.IsValid)
            return BadRequest("Invalid data.");

        users.Add(user);
        return Ok();
    }

    public IHttpActionResult Put(string name, User user)
    {
        if (!ModelState.IsValid)
            return BadRequest("Invalid data.");

        var existingUser = users.FirstOrDefault(u => u.Name == name);
        if (existingUser == null)
            return NotFound();

        existingUser.Name = user.Name;
        existingUser.Age = user.Age;

        return Ok();
    }

    public IHttpActionResult Delete(string name)
    {
        var user = users.FirstOrDefault(u => u.Name == name);
        if (user == null)
            return NotFound();

        users.Remove(user);
        return Ok();
    }
}
