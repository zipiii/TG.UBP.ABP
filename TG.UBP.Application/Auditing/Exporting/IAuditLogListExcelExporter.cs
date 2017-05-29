using System.Collections.Generic;
using TG.UBP.Auditing.Dto;
using TG.UBP.Dto;

namespace TG.UBP.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
