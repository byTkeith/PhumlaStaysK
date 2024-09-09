SELECT 
    DB_NAME() AS DbName, 
    physical_name AS CurrentLocation
FROM 
    sys.master_files
WHERE 
    database_id = DB_ID('bookingSystem');