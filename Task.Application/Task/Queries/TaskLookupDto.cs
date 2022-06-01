using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Application.Common.Mapping;
using Tasks.Domain;

namespace Tasks.Application.Task.Queries
{
   public class TaskLookupDto : IMapWith<Tasks.Domain.Task>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Tasks.Domain.Task, TaskLookupDto>()
                .ForMember(taskDto => taskDto.Id,
                opt => opt.MapFrom(task => task.Id))
                .ForMember(taskDto => taskDto.Title,
                opt => opt.MapFrom(task => task.Title));
        }
    }
}
