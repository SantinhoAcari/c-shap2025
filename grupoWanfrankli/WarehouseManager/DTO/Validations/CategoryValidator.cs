using FluentValidation;

public class CategoryValidator : AbstractValidator<CreateCategoryDTO> {
    public CategoryValidator() {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Nome não pode ser vazio").NotNull().WithMessage("Nome é um campo obrigatório");
    }
}