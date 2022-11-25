using _4FinanceTMS.InputModels;
using _4FinanceTMS.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _4FinanceTMS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {

        private readonly ITeacherRepository teacherRepository;

        //constructor to inject the teacherRepository in the class
        public TeachersController(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeachers()
        {
            //here we're getting the teachers from th data base using the reprository
            var teachers = await teacherRepository.GetAllAsync();

            //declare a teacher dto list to return it to the user
            var teachersDto = new List<Dtos.TeacherDto>();

            //loop over the teachers model
            teachers.ToList().ForEach(teacher =>
            {
                //create a teacher dto and fill it from the teacher model
                var teacherDto = new Dtos.TeacherDto()
                {
                    TeacherId = teacher.Id,
                    Name = teacher.Name,
                    Email = teacher.Email,
                    Specality = teacher.Specality,
                };
                //add each teacher dto to the teachers list
                teachersDto.Add(teacherDto);
            });
            return Ok(teachersDto);
        }

        [HttpGet("{id:guid}")]
        [ActionName("GetTeacherAsync")]
        public async Task<IActionResult> GetTeacherAsync(Guid id)
        {
            //use the repository
            var teacher = await teacherRepository.GetAsync(id);

            if (teacher == null)
            {
                return NotFound();
            }

            //mappig
            var teacherDto = new Dtos.TeacherDto()
            {
                TeacherId = teacher.Id,
                Name = teacher.Name,
                Email = teacher.Email,
                Specality = teacher.Specality,
            };
            return Ok(teacherDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeacher(CreateTeacherInputModel createTeacherInputModel)
        {
            var teacher = new Models.Teachers()
            {
                Name = createTeacherInputModel.Name,
                Email = createTeacherInputModel.Email,
                Specality = createTeacherInputModel.Specality,
            };

            teacher = await teacherRepository.CreateTeacherAsync(teacher);
            var teacherDto = new Dtos.TeacherDto
            {
                TeacherId = teacher.Id,
                Name = teacher.Name,
                Email = teacher.Email,
                Specality = teacher.Specality,
            };
            return CreatedAtAction(
                nameof(GetTeacherAsync),
                new { id = teacherDto.TeacherId },
                teacherDto);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTeacherAsync(Guid id)
        {
            var teacher = await teacherRepository.DeleteTeacherAsync(id);

            if (teacher == null)
            {
                return NotFound();
            }

            var teacherDto = new Dtos.TeacherDto
            {
                Name = teacher.Name,
                Email = teacher.Email,
                Specality = teacher.Specality,
            };
            return Ok(teacherDto);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult>UpdatreTeacherAsync([FromRoute] Guid  id, [FromBody] UpdateTeacherInputModel updateTeacherInputModel)
        {
            //convert DTO to Model
            var teacher = new Models.Teachers()
            {
                Name = updateTeacherInputModel.Name,
                Specality = updateTeacherInputModel.Specality,
            };

            //Update Teacher using teacher reprository
            teacher = await teacherRepository.UpdateTeacherAsync(id, teacher);

            //If null return not found
            if(teacher == null)
            {
                return NotFound();
            }

            //Convert from Model back to DTO
            var teacherDto = new Dtos.TeacherDto
            {
                TeacherId = teacher.Id,
                Name = teacher.Name,
                Email = teacher.Email,
                Specality = teacher.Specality,
            };

            //Return Ok response
            return Ok(teacherDto);
        }
    }
}
