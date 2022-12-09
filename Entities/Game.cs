using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities
{
    public class Game : EntityBase
    {
        [Required(ErrorMessage = "Заполните название игры")]
        [Display(Name = "Название игры")]
        public override string Name { get; set; }

        [Display(Name = "Описание игры")]
        public override string Description { get; set; }

        [Display(Name = "Категория игры")]
        public override string Category { get; set; }

        [Display(Name = "Цена игры")]
        public override double Price { get; set; }

        [Display(Name = "Трейлер игры")]
        public override string Video { get; set; }
    }
}
