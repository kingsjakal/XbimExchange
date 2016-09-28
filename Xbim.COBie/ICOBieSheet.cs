﻿using System.Collections.Generic;
using Xbim.COBie.Contracts;
using Xbim.Ifc;


namespace Xbim.COBie
{
    public interface ICOBieSheet<out T> where T : COBieRow
    {

        T this[int i] { get; }
        int RowCount { get; }
        IEnumerable<T> RemovedRows { get; }
        string SheetName { get; }
        Dictionary<int, COBieColumn> Columns { get; }
        IEnumerable<COBieColumn> KeyColumns { get; }
        IEnumerable<COBieColumn> ForeignKeyColumns { get; }
        Dictionary<string, HashSet<string>> Indices { get; }
        COBieErrorCollection Errors { get; }
        object SheetMetaData { get; set; }


        List<string> ValidateComponentMerge(IfcStore model, COBieMergeRoles fileRoles);
        int ValidateAttributeMerge(List<string> Keys);
        int ValidateTypeMerge(List<string> GlobalIds);
        int ValidateSystemMerge(List<string> names);
        void BuildIndices();
        void SetRowsHashCode();
        bool HasMergeHashCode(string hash, bool addHash);
        T AddNewRow();
        void AddRow(COBieRow cOBieRow);
        void AddRemovedRow(COBieRow cOBieRow);

        ICOBieSheet<T> CreateEmptySheet();

        void Validate(COBieWorkbook cOBieWorkbook, ErrorRowIndexBase errorRowIdx, ICOBieSheetValidationTemplate SheetValidator);
    }
}
