public enum Rating{
    Good,
    Great,
    Excellent
}

public struct Dog{
public string name;
public float age;
public string owner;
public Rating rating;

public Dog(string n, float a, string o, Rating r){
    name = n;
    age = a;
    owner = o;
    rating = r;
}

public override string ToString()
{
    return 
    $"{base.ToString()} name: {this.name.ToString()}\nAge: {this.age.ToString()}\nOwner: {this.owner}\nRating: {this.rating.ToString()}";
}
}
