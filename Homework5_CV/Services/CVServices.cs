using Homework5_CV.Commands;
using Homework5_CV.Data;
using Homework5_CV.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Homework5_CV.Services
{
    public class CVServices
    {
        private readonly AppDbContext _context;

        public CVServices(AppDbContext context)
        {
            _context = context;
        }

        //method to add a cv
        public async Task<int> addCV(CvCommand cvCmd)
        {
            var cv = new DataModel
            {
                FirstName = cvCmd.FirstName,
                LastName = cvCmd.LastName,
                Birthday = cvCmd.Birthday,
                Nationality = cvCmd.Nationality,
                Sex = cvCmd.Sex,
                Skills = cvCmd.Skills,
                Email = cvCmd.Email,
                Password = cvCmd.Password,
                PhotoUrl = cvCmd.PhotoUrl
            };
            _context.CV.Add(cv);
            await _context.SaveChangesAsync();
            return cv.Id;
        }

        public async Task<DataModel> GetCVById(int id)
        {
            return await _context.CV.FindAsync(id);
        }

        public async Task<List<DataModel>> GetAllCVs()
        {
            var cvs= await _context.CV.ToListAsync();
            if (cvs.Count == 0)
            {
                return null;
            }
            else return cvs;
        }

    }
}
