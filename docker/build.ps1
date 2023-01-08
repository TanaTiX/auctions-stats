$watch = [System.Diagnostics.Stopwatch]::StartNew()

Write-Host "Starting building..."
docker-compose build --force-rm --parallel --build-arg -p auctions-stats

$watch.Stop() #Остановка таймера
$elapsed = $watch.Elapsed
Write-Host "Built in $elapsed" -ForegroundColor Green


