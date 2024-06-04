using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Client.Models;
public class Game
{
public int Id { get; set; }       

[Required] 
[StringLength(50)]
public required string Name { get; set; }

[Required] 
[StringLength(50)]
public required string Genre { get; set; }

[Required] 
[Range(1,1000)]
public float Price { get; set; }

[Required] 

public DateTime ReleaseDate { get; set; }

}
