namespace UnionCore.DataAccess
{
    public class Repository<T>(DataContext context) : IRepository<T> where T : class
    {
        protected readonly DataContext _context = context;

        public async Task Add(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var entity = await GetById(id);
            await Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<T> GetById(string id)
        {
            T entity = await _context.Set<T>().FindAsync(id);
            return entity != null
                ? entity : throw new NullReferenceException($"Fandt ikke noget med ID: {id}");
        }

        public async Task Update(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
