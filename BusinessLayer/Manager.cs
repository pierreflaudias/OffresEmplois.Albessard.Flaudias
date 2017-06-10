using BusinessLayer.Commands;
using BusinessLayer.Queries;
using Model.Entities;
using Model.FluentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Manager
    {
        private readonly ContextFluent _context;

        private static Manager _instance = null;

        /// <summary>
        /// The constructor!
        /// </summary>
        private Manager()
        {
            _context = new ContextFluent();
        }

        /// <summary>
        ///Get the instance of the pattern Singleton
        /// </summary>
        public static Manager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Manager();
                return _instance;
            }
        }

        #region Employee

        /// <summary>
        /// Récupérer une liste d'employees en base
        /// </summary>
        /// <returns>Employees List</returns>
        public List<Employee> GetAllEmployees()
        {
            EmployeeQuery eq = new EmployeeQuery(_context);
            return eq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer un employee en base
        /// </summary>
        /// <param name="employeeId">Id de l'employee</param>
        /// <returns>Employee</returns>
        public Employee GetEmployee(int employeeId)
        {
            EmployeeQuery eq = new EmployeeQuery(_context);
            return eq.GetById(employeeId);
        }

        /// <summary>
        /// Ajouter un employee en base
        /// </summary>
        /// <param name="e">Employee à ajouter</param>
        /// <returns>identifiant du nouvel employee</returns>
        public int AddEmployee(Employee e)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            EmployeeCommand ec = new EmployeeCommand(_context);
            return ec.Add(e);
        }

        /// <summary>
        /// Modifier un employee en base
        /// </summary>
        /// <param name="e">Employee à modifier</param>
        public void UpdateEmployee(Employee e)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            EmployeeCommand ec = new EmployeeCommand(_context);
            ec.Update(e);
        }

        /// <summary>
        /// Supprimer un employee en base
        /// </summary>
        /// <param name="employeeId">Identifiant de l'employee à supprimer</param>
        public void DeleteEmployee(int employeeId)
        {
            EmployeeCommand ec = new EmployeeCommand(_context);
            ec.Delete(employeeId);
        }

        #endregion

        #region Experience

        /// <summary>
        /// Récupérer une liste d'experiences en base
        /// </summary>
        /// <returns>Experiences List</returns>
        public List<Experience> GetAllExperiences()
        {
            ExperienceQuery eq = new ExperienceQuery(_context);
            return eq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer un Experience en base
        /// </summary>
        /// <param name="expId">Id de l'Experience</param>
        /// <returns>Experience</returns>
        public Experience GetExperience(int expId)
        {
            ExperienceQuery eq = new ExperienceQuery(_context);
            return eq.GetById(expId);
        }

        /// <summary>
        /// Ajouter une Experience en base
        /// </summary>
        /// <param name="e">Experience à ajouter</param>
        /// <returns>identifiant du nouvel Experience</returns>
        public int AddExperience(Experience e)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ExperienceCommand ec = new ExperienceCommand(_context);
            return ec.Add(e);
        }

        /// <summary>
        /// Modifier un Experience en base
        /// </summary>
        /// <param name="e">Experience à modifier</param>
        public void UpdateExperience(Experience e)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ExperienceCommand ec = new ExperienceCommand(_context);
            ec.Update(e);
        }

        /// <summary>
        /// Supprimer un Experience en base
        /// </summary>
        /// <param name="experienceId">Identifiant de l'Experience à supprimer</param>
        public void DeleteExperience(int experienceId)
        {
            ExperienceCommand ec = new ExperienceCommand(_context);
            ec.Delete(experienceId);
        }

        #endregion

        #region Formation

        /// <summary>
        /// Récupérer une liste de Formations en base
        /// </summary>
        /// <returns>Formations List</returns>
        public List<Formation> GetAllFormations()
        {
            FormationQuery fq = new FormationQuery(_context);
            return fq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer un Formation en base
        /// </summary>
        /// <param name="formationId">Id de l'Formation</param>
        /// <returns>Experience</returns>
        public Formation GetFormation(int formationId)
        {
            FormationQuery fq = new FormationQuery(_context);
            return fq.GetById(formationId);
        }

        /// <summary>
        /// Ajouter une Formation en base
        /// </summary>
        /// <param name="e">Formation à ajouter</param>
        /// <returns>identifiant du nouvel Formation</returns>
        public int AddFormation(Formation f)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            FormationCommand fc = new FormationCommand(_context);
            return fc.Add(f);
        }

        /// <summary>
        /// Modifier un Formation en base
        /// </summary>
        /// <param name="e">Formation à modifier</param>
        public void UpdateFormation(Formation f)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            FormationCommand fc = new FormationCommand(_context);
            fc.Update(f);
        }

        /// <summary>
        /// Supprimer un Formation en base
        /// </summary>
        /// <param name="formationId">Identifiant de l'Formation à supprimer</param>
        public void DeleteFormation(int formationId)
        {
            FormationCommand fc = new FormationCommand(_context);
            fc.Delete(formationId);
        }

        #endregion

        #region Offer
        /// <summary>
        /// Récupérer une liste de Offers en base
        /// </summary>
        /// <returns>Offers List</returns>
        public List<Offer> GetAllOffers()
        {
            OfferQuery oq = new OfferQuery(_context);
            return oq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer un Offer en base
        /// </summary>
        /// <param name="offerId">Id de l'Offer</param>
        /// <returns>Offer</returns>
        public Offer GetOffer(int offerId)
        {
            OfferQuery fq = new OfferQuery(_context);
            return fq.GetById(offerId);
        }

        /// <summary>
        /// Ajouter une Offer en base
        /// </summary>
        /// <param name="e">Offer à ajouter</param>
        /// <returns>identifiant du nouvel Offer</returns>
        public int AddOffer(Offer o)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            OfferCommand oc = new OfferCommand(_context);
            return oc.Add(o);
        }

        /// <summary>
        /// Modifier un Offer en base
        /// </summary>
        /// <param name="e">Offer à modifier</param>
        public void UpdateOffer(Offer o)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            OfferCommand oc = new OfferCommand(_context);
            oc.Update(o);
        }

        /// <summary>
        /// Supprimer un Offer en base
        /// </summary>
        /// <param name="offerId">Identifiant de l'Offer à supprimer</param>
        public void DeleteOffer(int offerId)
        {
            OfferCommand oc = new OfferCommand(_context);
            oc.Delete(offerId);
        }

        #endregion

        #region Status
        /// <summary>
        /// Récupérer une liste de Statuses en base
        /// </summary>
        /// <returns>Statuses List</returns>
        public List<Status> GetAllStatuses()
        {
            StatusQuery sq = new StatusQuery(_context);
            return sq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer un Status en base
        /// </summary>
        /// <param name="statusId">Id de l'Status</param>
        /// <returns>Status</returns>
        public Status GetStatus(int statusId)
        {
            StatusQuery sq = new StatusQuery(_context);
            return sq.GetById(statusId);
        }

        /// <summary>
        /// Ajouter une Status en base
        /// </summary>
        /// <param name="e">Status à ajouter</param>
        /// <returns>identifiant du nouvel Status</returns>
        public int AddStatus(Status s)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            StatusCommand sc = new StatusCommand(_context);
            return sc.Add(s);
        }

        /// <summary>
        /// Modifier un Status en base
        /// </summary>
        /// <param name="e">Status à modifier</param>
        public void UpdateStatus(Status s)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            StatusCommand sc = new StatusCommand(_context);
            sc.Update(s);
        }

        /// <summary>
        /// Supprimer un Status en base
        /// </summary>
        /// <param name="statusId">Identifiant de l'Status à supprimer</param>
        public void DeleteStatus(int statusId)
        {
            StatusCommand sc = new StatusCommand(_context);
            sc.Delete(statusId);
        }

        #endregion

        #region Postulation
        /// <summary>
        /// Récupérer une liste de Postulations en base
        /// </summary>
        /// <returns>Postulation List</returns>
        public List<Postulation> GetAllPostulations()
        {
            PostulationQuery pq = new PostulationQuery(_context);
            return pq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer une liste de Postulations en base par offre
        /// </summary>
        /// <param name="o">Offer</param>
        /// <returns>Postulation List</returns>
        public List<Postulation> GetPostulationsFromOffer(Offer o)
        {
            PostulationQuery pq = new PostulationQuery(_context);
            return pq.GetByOffer(o).ToList();
        }

        /// <summary>
        /// Récupérer une liste de Postulations en base par employee
        /// </summary>
        /// <param name="e">Employee</param>
        /// <returns>Postulation List</returns>
        public List<Postulation> GetPostulationsFromEmployee(Employee e)
        {
            PostulationQuery pq = new PostulationQuery(_context);
            return pq.GetByEmployee(e).ToList();
        }

        /// <summary>
        /// Ajouter une Postulation en base
        /// </summary>
        /// <param name="e">Postulation à ajouter</param>
        /// <returns>identifiant du nouvel Postulation</returns>
        public int AddPostulation(Postulation p)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            PostulationCommand pc = new PostulationCommand(_context);
            return pc.Add(p);
        }

        /// <summary>
        /// Modifier un Postulation en base
        /// </summary>
        /// <param name="e">Postulation à modifier</param>
        public void UpdatePostulation(Postulation p)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            PostulationCommand pc = new PostulationCommand(_context);
            pc.Update(p);
        }

        /// <summary>
        /// Supprimer un Postulation en base
        /// </summary>
        /// <param name="postulationId">Identifiant de l'Postulation à supprimer</param>
        public void DeletePostulation(int postulationId)
        {
            PostulationCommand pc = new PostulationCommand(_context);
            pc.Delete(postulationId);
        }

        #endregion

    }
}
