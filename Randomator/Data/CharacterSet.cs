using System.Collections.Generic;

namespace Randomator.Data;

/*
 *
 * Generic data, such as character sets
 * 
 */

internal static class CharacterSet
{
 public static readonly List<string> alphaLower = new List<string>()
 {
  "a", "b", "c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
 };
 
 public static readonly List<string> alphaUpper = new List<string>()
 {
  "A", "B", "C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
 };
 
 public static readonly List<string> numeric = new List<string>()
 {
  "0", "1", "2","3","4","5","6","7","8","9"
 };
 
 public static readonly List<string> special = new List<string>()
 {
  "!", "@", "#","$","%","^","&","*","(",")","-","_","+","=","{","[","}","]","|",@"\",":",";","'","<",",",">",".","?","/","`","~"
 };
}