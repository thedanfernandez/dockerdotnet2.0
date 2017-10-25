#!/bin/bash

set -e
run_cmd="dotnet run --server.urls http://*:80"

#until dotnet ef database update --context app.Data.ApplicationDbContext; do
#>&2 echo "running ef restore for app.Data.ApplicationDbContext"
#sleep 1
#done
>&2 echo "before dotnet ef command"

# until dotnet ef database update --context app.Models.ProductContext; do
# >&2 echo "running ef restore for app.Models.ProductContext"
# sleep 1
# done

>&2 echo "SQL Server is up - executing command"
exec $run_cmd