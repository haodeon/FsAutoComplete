module FsAutoComplete.CodeFix.UpdateTypeAbbreviationInSignatureFile

open FsAutoComplete.CodeFix.Types

val title: string
val fix: getParseResultsForFile: GetParseResultsForFile -> CodeFix
