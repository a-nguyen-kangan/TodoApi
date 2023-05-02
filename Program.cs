var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Object instantiation
var leg1 = new Leg();
leg1.Length = 100;
leg1.Works = true;
leg1.Side = 'R';

var leg2 = new Leg();
leg2.Length = 90;
leg2.Works = false;
leg2.Side = 'L';

var person1 = new Person();
person1.Name = "Fred";
person1.Legs = new List<Leg>();
person1.Legs.Add(leg1);
person1.Legs.Add(leg2);


var todo1 = new Todo();
todo1.Description = "Learn C#";
todo1.Completed = false;
todo1.Id = 1;

var todo2 = new Todo();
todo2.Id = 2;
todo2.Description = "Learn PostGres";
todo2.Completed = false;


// ------------------

app.MapGet("/", () => "Hello World!");
app.MapGet("/Fred", () => GetNewLeg());
app.MapGet("/Kick/{LegNum}", (int LegNum) => Kick(LegNum));
app.MapGet("/Leg/{legNum}", (int legNum) => GetLeg(legNum));
app.MapGet("/Person", () => person1);



app.MapGet("/Todo", () => "TodoList");

app.Run();

string GetNewLeg() {
    return "Sorry can't get you a new leg but here's a new walking stick!";
}

string Kick(int LegNum) {
    if(LegNum == 1) {
        return leg1.Kick();
    } else if(LegNum == 2) {
        return leg2.Kick();
    }

    return $"Can't kick with {LegNum} leg.  How many legs do you have you weirdo!";
}

Leg GetLeg(int legNum)
{
    switch(legNum) {
        case 1:
            return leg1;
        case 2:
            return leg2;
        default:
            return null;
    }
}