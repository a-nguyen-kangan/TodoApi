public class Leg {
    public int Length { get; set; }
    public bool Works { get; set; }
    public char Side { get; set; }

    public string Kick() {
        if(this.Works == true) {
            return "Kick";
        }

        return "Can't Kick";
        
    }
}

public class Person {
    public string Name { get; set; }
    public List<Leg> Legs { get; set; }

}