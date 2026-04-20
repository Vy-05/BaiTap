namespace PolicyService.Api.Commands.Dtos;

public enum QuestionType
{
    Numeric = 0,
    Choice = 1
}

public abstract class QuestionAnswer
{
    public string QuestionCode { get; set; } = string.Empty;
    public abstract QuestionType QuestionType { get; }
}

public class ChoiceQuestionAnswer : QuestionAnswer
{
    public string? Answer { get; set; }
    public override QuestionType QuestionType => QuestionType.Choice;
}

public class NumericQuestionAnswer : QuestionAnswer
{
    public decimal Answer { get; set; }
    public override QuestionType QuestionType => QuestionType.Numeric;
}

public class PersonDto
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string TaxId { get; set; } = string.Empty;
}

public class AddressDto
{
    public string Country { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
}
