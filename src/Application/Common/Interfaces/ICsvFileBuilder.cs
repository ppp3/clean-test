using template.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace template.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
