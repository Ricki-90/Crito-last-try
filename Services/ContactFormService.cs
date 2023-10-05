using Crito_project.Contexts;
using Crito_project.Models;

namespace Crito_project.Services;

public class ContactFormService
{
    private readonly DataContext _context;

    public ContactFormService(DataContext context)
    {
        _context = context;
    }

    public async Task AddContactUsFormAsync(ContactUsForm form)
    {
        _context.ContactUsForm.Add(new ContactFormEntity 
        { 
            Name = form.Name,
            Email = form.Email,
            Message = form.Message,
            RedirectUrl = form.RedirectUrl
        });
        await _context.SaveChangesAsync();
    }
}
