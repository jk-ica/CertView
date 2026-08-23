using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CertView.Services;
using CertView.Models;
using CertView.Helpers;

namespace CertView.ViewModels
{
    internal partial class MainViewModel(IFilePickerService filePickerService, ICertificateReaderService certificateReaderService) : ObservableObject
    {
        public string? FilePath { get; set; }
        public FileInfo? File { get; set; }
        public bool IsFilePicked => File != null;
        public CertificateInfo? CertificateInfo { get; set; }

        [ObservableProperty]
        private List<CertFieldsMapper.CertificateField> certificateFields = [];

        private readonly IFilePickerService _filePickerService = filePickerService;
        private readonly ICertificateReaderService _certificateReaderService = certificateReaderService;

        [RelayCommand]
        private void Browse()
        {
            File = _filePickerService.PickFile();
        }

        [RelayCommand]
        private void Open()
        {
            CertificateInfo = _certificateReaderService.ReadCertificate(File);
            CertificateFields = CertFieldsMapper.Map(CertificateInfo);
        }
    }
}
