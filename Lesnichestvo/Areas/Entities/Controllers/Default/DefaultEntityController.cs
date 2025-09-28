using Lesnichestvo.DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Lesnichestvo.Areas.Entities.Controllers.Default
{
    [Authorize]
    [Area("Entities")]
    public class DefaultEntityController<TEntity>(IBaseRepository<TEntity> repository) : Controller where TEntity : class, IEntity
    {
        public async virtual Task<IActionResult> Index(CancellationToken token)
        {
            var all = await repository.GetAllAsync(token);
            return View(all);
        }

        [HttpGet]
        [Authorize(Roles = "admin, manager")]
        public async virtual Task<IActionResult> BeginUpdate([FromRoute] int id, CancellationToken token)
        {
            var entity = (await repository.GetAllAsync(token))
                .Where(x => x.ID == id).First();
            return View("Update", entity);
        }

        [HttpPost]
        [Authorize(Roles = "admin, manager")]
        public async Task<IActionResult> FinishUpdate([FromForm] TEntity entity, CancellationToken token)
        {
            if(!ModelState.IsValid)
            {
                return View("Update", entity);
            }

            try
            {
                await repository.UpdateAsync(entity, token);
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx)
            {
                ModelState.AddModelError("", "Ошибка базы данных: " + sqlEx.Message);
                return View("Update", entity);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, manager")]
        public async Task<IActionResult> Create([FromForm] TEntity entity, CancellationToken token)
        {
            if (!ModelState.IsValid)
            {
                var all = await repository.GetAllAsync(token);
                return View("Index", all);
            }

            try
            {
                await repository.CreateAsync(entity, token);
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx)
            {
                ModelState.AddModelError("", "Ошибка базы данных: " + sqlEx.Message);
                var all = await repository.GetAllAsync(token);
                return View("Index", all);
            }
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
        {
            var all = await repository.GetAllAsync(token);
            var toDelete = all.Where(x => x.ID == id).FirstOrDefault();
            if (toDelete is null)
            {
                ModelState.AddModelError("", "Запись не найдена");
                return View("Index", all);
            }
            try
            {
                await repository.DeleteAsync(toDelete, token);
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx)
            {
                ModelState.AddModelError("", "Ошибка базы данных: " + sqlEx.Message);
                return View("Index", all);
            }
        }
    }
}
