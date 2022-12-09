using System;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid GameId { get; set; }

        [Display(Name = "Название")]
        public virtual string Name { get; set; }

        [Display(Name = "Описание")]
        public virtual string Description { get; set; }

        [Display(Name = "Категория")]
        public virtual string Category { get; set; }

        [Display(Name = "Цена")]
        public virtual double Price { get; set; }

        [Display(Name = "Титульная картинка")]
        public virtual string TitleImage { get; set; }

        [Display(Name = "Видео")]
        public virtual string Video { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
