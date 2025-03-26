using FluentValidation;

public class ReceiverValidator : AbstractValidator<CreateReceiverDTO> {
    public ReceiverValidator() {
        RuleFor(x => x.Name).NotNull().WithMessage("Nome é um campo obrigatório").NotEmpty().WithMessage("Nome não pode ser vazio");
    }
}