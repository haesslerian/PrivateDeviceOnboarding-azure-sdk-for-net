echo "Replace Provider References"
$configFiles = Get-ChildItem .\Generated *Resource.cs
foreach ($file in $configFiles)
{
    (Get-Content $file.PSPath) |
    Foreach-Object { $_ -replace 'public static readonly ResourceType ResourceType = "Microsoft.DeviceOnboarding', 'public static readonly ResourceType ResourceType = $"{Environment.GetEnvironmentVariable("OnboardingServiceProvider")}' } |
    Foreach-Object { $_ -replace 'Microsoft.DeviceOnboarding', '{Environment.GetEnvironmentVariable("OnboardingServiceProvider")}' } |
    Set-Content $file.PSPath
    echo $file.PSPath
}
(Get-Content .\Generated\Extensions\MockableDeviceOnboardingArmClient.cs).Replace('"Microsoft.DeviceOnboarding', '$"{System.Environment.GetEnvironmentVariable("OnboardingServiceProvider")}') | Set-Content .\Generated\Extensions\MockableDeviceOnboardingArmClient.cs
