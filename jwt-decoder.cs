using System.IdentityModel.Tokens.Jwt;

try
{
    Console.WriteLine(
        new JwtSecurityToken(Console.ReadLine()).ToString().Replace("}.{", "}\n{")
    );
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}