import type WarehouseWing from "./WarehouseWing"

export default interface Warehouse {
	id: string;
	name: string;
	locationLat: string;
	locationLong: string;
	warehouseWing: WarehouseWing;
}
