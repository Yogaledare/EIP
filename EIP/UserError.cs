namespace EIP;

public abstract class UserError {
    public abstract string UEMessage();
}

public class NumericInputError : UserError {
    public override string UEMessage() {
        return "You tried to use a numeric input in a text only ﬁeld. This ﬁred an error!";
    }
}

public class TextInputError : UserError {
    public override string UEMessage() {
        return "You tried to use a text input in a numeric only ﬁeld. This ﬁred an error!";
    }
}

public class ClothesOrderError : UserError {
    public override string UEMessage() {
        return "You tried to put on your shoes before you put on your pants. This ﬁred an error!"; 
    }
} 

public class GearError : UserError {
    public override string UEMessage() {
        return "You tried to put in the reverse gear while driving on the highway. This ﬁred an error!"; 
    }
} 

public class SnakeError : UserError {
    public override string UEMessage() {
        return "You tried to pet a snake. This ﬁred an error!"; 
    }
}


