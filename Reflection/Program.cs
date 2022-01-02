using Reflection;
using System.Reflection;

var privateClass = new PrivateClass();


var prop = privateClass.GetType().GetField("subPrivateClass", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(privateClass);
var prop2 = prop.GetType().GetField("privateField", BindingFlags.NonPublic | BindingFlags.Instance);

PrivateClass x = MakeACopy(ref privateClass);
privateClass = new PrivateClass();

prop2.SetValue(prop, 101);
privateClass = x;

static PrivateClass MakeACopy(ref PrivateClass refArgument)
{
    PrivateClass objectToBeReturned = refArgument;

    return objectToBeReturned;
}